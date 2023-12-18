using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading.Channels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsRabbitSender
{
	public partial class FormSender : Form
	{
		private IMongoCollection<User> usersCollection;
		private IMongoCollection<Message> chatCollection;
		private MongoClient dbClient;
		private IModel channel;
		User currentUser;
		EventingBasicConsumer basicEvent;
		string dbUrl = Environment.DbUrl;
		public FormSender() {
			InitializeComponent();
			Clear();

			dbClient = new MongoClient(dbUrl);

			var database = dbClient.GetDatabase("chat-rabbit");
			usersCollection = database.GetCollection<User>("auth");
			chatCollection = database.GetCollection<Message>("messages");

			buttonAuth.Click += ButtonAuth_Click;
			buttonSend.Click += ButtonSend_Click;
			buttonSended.Click += ButtonSended_Click;
			buttonRecived.Click += ButtonRecived_Click;

			ConnectionFactory connectionFactory = new ConnectionFactory();
			connectionFactory.HostName = "localhost";
			basicEvent = new EventingBasicConsumer(channel);

			IConnection connection = connectionFactory.CreateConnection();
			channel = connection.CreateModel();
			channel.ExchangeDeclare(exchange: "logs", type: ExchangeType.Fanout);

			basicEvent.Received += BasicEvent_Received;
		}

		private async void ButtonRecived_Click(object? sender, EventArgs e) {
			if(textBox1.Text != null || textBox1.Text != "") {
				var filter = Builders<Message>.Filter.Eq(m => m.reciver, textBox1.Text);
				var messages = await chatCollection.Find(filter).ToListAsync();

				printMessages(messages);
			}
		}

		private async void ButtonSended_Click(object? sender, EventArgs e) {
			if(textBox1.Text != null || textBox1.Text != "") {
				var filter = Builders<Message>.Filter.Eq(m => m.sender, textBox1.Text);
				var messages = await chatCollection.Find(filter).ToListAsync();

				printMessages(messages);
			}
		}
		private void printMessages(List<Message> list) {
			Clear();
			foreach(var message in list) {
				string mess = $"{message.sender}->{message.reciver}: {message.text}";
				listBox2.Items.Add(mess);
			}
		}
		private void Clear() {
			listBox1.Items.Clear();
			listBox2.Items.Clear();
		}

		private void ButtonSend_Click(object? sender, EventArgs e) {
			String message = textBox2.Text;
			if(message != "" || message != null) {
				string username = currentUser.username;
				String fullMessage = $"{username}: {message}";
				byte[] body = Encoding.UTF8.GetBytes(fullMessage);

				string exchenge = "";
				if(textBox3.Text == "" || textBox3.Text == null) {
					exchenge = "logs";
				}
				channel.BasicPublish(
						exchange: exchenge,
						routingKey: textBox3.Text,
						basicProperties: null,
						body: body);

				insertMessage(username, textBox3.Text, message);
			}
		}
		private async void insertMessage(string sender, string reciver, string text) {
			Message mess = new() {
				sender = sender,
				reciver = reciver,
				text = text
			};

			await chatCollection.InsertOneAsync(mess);
		}

		private void BasicEvent_Received(object? sender, BasicDeliverEventArgs e) {
			byte[] body = e.Body.ToArray();
			String message = Encoding.UTF8.GetString(body);

			if(message != null) {
				if(listBox1.InvokeRequired) {
					// Utilizza il metodo Invoke per aggiornare il controllo UI
					listBox1.Invoke(new Action(() => listBox1.Items.Add(message)));
				} else {
					// Se già nel thread UI, aggiorna direttamente il controllo
					listBox1.Items.Add(message);
				}
			}
		}

		private void ButtonAuth_Click(object? sender, EventArgs e) {
			string username = textBox4.Text;
			string password = textBox5.Text;

			// Verifica delle credenziali
			if(isAuthenticated(username, password)) {
				initializeUser(username, password);
				initializeRoute(currentUser.username);

				MessageBox.Show("Accesso riuscito!");
			} else {
				MessageBox.Show("Accesso fallito. Verifica le credenziali.");
			}
		}
		private bool isAuthenticated(string username, string password) {
			return AuthenticateUser(username, password) != null;
		}
		private User AuthenticateUser(string username, string password) {
			var user = usersCollection.Find(u => u.username == username && u.password == password).FirstOrDefault();
			return user != null ? user : null;
		}
		private void initializeRoute(string route) {
			channel.QueueBind(queue: route,
				  exchange: "logs",
				  routingKey: string.Empty);

			channel.QueueDeclare(
				queue: route,
				durable: false,
				exclusive: false,
				autoDelete: false,
				arguments: null);

			channel.BasicConsume(
				queue: route,
				autoAck: true,
				consumer: basicEvent);
		}
		private void initializeUser(string username, string password) {
			currentUser = AuthenticateUser(username, password);
			labelAuth.Text = $"Benvenuto {currentUser.username}";
			buttonSend.Enabled = true;
		}
	}
}