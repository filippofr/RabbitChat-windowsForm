using MongoDB.Bson;
using MongoDB.Driver;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace WindowsFormRabbitReciver
{
	public partial class FormReciver : Form
	{
		public FormReciver() {
			InitializeComponent();

			ConnectionFactory connectionFactory = new ConnectionFactory();
			connectionFactory.HostName = "localhost";

			IConnection connection = connectionFactory.CreateConnection();
			IModel channel = connection.CreateModel();

			channel.QueueDeclare(
				queue: "coda",
				durable: false,
				exclusive: false,
				autoDelete: false,
				arguments: null);

			EventingBasicConsumer basicEvent = new EventingBasicConsumer(channel);

			basicEvent.Received += BasicEvent_Received;

			channel.BasicConsume(queue: "coda",
				autoAck: true,
				consumer: basicEvent);
		}
		private void BasicEvent_Received(object? sender, BasicDeliverEventArgs e) {
			byte[] body = e.Body.ToArray();

			String message = Encoding.UTF8.GetString(body);
			if(message != null) {
				listBox1.Text = message;
			}
		}
	}
}