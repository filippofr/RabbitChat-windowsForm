namespace WinFormsRabbitSender
{
	partial class FormSender
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			tabControl1 = new TabControl();
			auth = new TabPage();
			label3 = new Label();
			label2 = new Label();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			buttonAuth = new Button();
			chat = new TabPage();
			labelAuth = new Label();
			listBox1 = new ListBox();
			textBox3 = new TextBox();
			label1 = new Label();
			buttonSend = new Button();
			textBox2 = new TextBox();
			Logs = new TabPage();
			label4 = new Label();
			listBox2 = new ListBox();
			buttonRecived = new Button();
			buttonSended = new Button();
			textBox1 = new TextBox();
			label5 = new Label();
			tabControl1.SuspendLayout();
			auth.SuspendLayout();
			chat.SuspendLayout();
			Logs.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(auth);
			tabControl1.Controls.Add(chat);
			tabControl1.Controls.Add(Logs);
			tabControl1.Location = new Point(1, 3);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(485, 473);
			tabControl1.TabIndex = 11;
			// 
			// auth
			// 
			auth.Controls.Add(label5);
			auth.Controls.Add(label3);
			auth.Controls.Add(label2);
			auth.Controls.Add(textBox5);
			auth.Controls.Add(textBox4);
			auth.Controls.Add(buttonAuth);
			auth.Location = new Point(4, 29);
			auth.Name = "auth";
			auth.Padding = new Padding(3);
			auth.Size = new Size(477, 440);
			auth.TabIndex = 0;
			auth.Text = "Autentication";
			auth.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(181, 233);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(181, 129);
			label2.Name = "label2";
			label2.Size = new Size(75, 20);
			label2.TabIndex = 3;
			label2.Text = "Username";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(181, 256);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(125, 27);
			textBox5.TabIndex = 2;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(181, 162);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(125, 27);
			textBox4.TabIndex = 1;
			// 
			// buttonAuth
			// 
			buttonAuth.Location = new Point(195, 318);
			buttonAuth.Name = "buttonAuth";
			buttonAuth.Size = new Size(94, 29);
			buttonAuth.TabIndex = 0;
			buttonAuth.Text = "Accedi";
			buttonAuth.UseVisualStyleBackColor = true;
			// 
			// chat
			// 
			chat.Controls.Add(labelAuth);
			chat.Controls.Add(listBox1);
			chat.Controls.Add(textBox3);
			chat.Controls.Add(label1);
			chat.Controls.Add(buttonSend);
			chat.Controls.Add(textBox2);
			chat.Location = new Point(4, 29);
			chat.Name = "chat";
			chat.Padding = new Padding(3);
			chat.Size = new Size(477, 440);
			chat.TabIndex = 1;
			chat.Text = "Chat";
			chat.UseVisualStyleBackColor = true;
			// 
			// labelAuth
			// 
			labelAuth.AutoSize = true;
			labelAuth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			labelAuth.Location = new Point(66, 14);
			labelAuth.Name = "labelAuth";
			labelAuth.Size = new Size(192, 31);
			labelAuth.TabIndex = 17;
			labelAuth.Text = "Login necessario";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 20;
			listBox1.Location = new Point(66, 96);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(344, 244);
			listBox1.TabIndex = 16;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(103, 63);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(307, 27);
			textBox3.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(66, 66);
			label1.Name = "label1";
			label1.Size = new Size(22, 20);
			label1.TabIndex = 12;
			label1.Text = "A:";
			// 
			// buttonSend
			// 
			buttonSend.Enabled = false;
			buttonSend.Location = new Point(379, 348);
			buttonSend.Name = "buttonSend";
			buttonSend.Size = new Size(31, 29);
			buttonSend.TabIndex = 14;
			buttonSend.Text = ">";
			buttonSend.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(66, 348);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(307, 27);
			textBox2.TabIndex = 13;
			// 
			// Logs
			// 
			Logs.Controls.Add(label4);
			Logs.Controls.Add(listBox2);
			Logs.Controls.Add(buttonRecived);
			Logs.Controls.Add(buttonSended);
			Logs.Controls.Add(textBox1);
			Logs.Location = new Point(4, 29);
			Logs.Name = "Logs";
			Logs.Size = new Size(477, 440);
			Logs.TabIndex = 2;
			Logs.Text = "Logs";
			Logs.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(84, 34);
			label4.Name = "label4";
			label4.Size = new Size(75, 20);
			label4.TabIndex = 4;
			label4.Text = "Username";
			// 
			// listBox2
			// 
			listBox2.FormattingEnabled = true;
			listBox2.ItemHeight = 20;
			listBox2.Location = new Point(9, 116);
			listBox2.Name = "listBox2";
			listBox2.Size = new Size(457, 304);
			listBox2.TabIndex = 3;
			// 
			// buttonRecived
			// 
			buttonRecived.Location = new Point(274, 81);
			buttonRecived.Name = "buttonRecived";
			buttonRecived.Size = new Size(94, 29);
			buttonRecived.TabIndex = 2;
			buttonRecived.Text = "Ricevuti";
			buttonRecived.UseVisualStyleBackColor = true;
			// 
			// buttonSended
			// 
			buttonSended.Location = new Point(124, 81);
			buttonSended.Name = "buttonSended";
			buttonSended.Size = new Size(94, 29);
			buttonSended.TabIndex = 1;
			buttonSended.Text = "Inviati";
			buttonSended.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(180, 31);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(208, 27);
			textBox1.TabIndex = 0;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.Location = new Point(151, 62);
			label5.Name = "label5";
			label5.Size = new Size(191, 35);
			label5.TabIndex = 5;
			label5.Text = "Autenticazione";
			// 
			// FormSender
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(491, 472);
			Controls.Add(tabControl1);
			Name = "FormSender";
			Text = "FormSender";
			tabControl1.ResumeLayout(false);
			auth.ResumeLayout(false);
			auth.PerformLayout();
			chat.ResumeLayout(false);
			chat.PerformLayout();
			Logs.ResumeLayout(false);
			Logs.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private TabControl tabControl1;
		private TabPage auth;
		private TabPage chat;
		private TextBox textBox3;
		private Label label1;
		private Button buttonSend;
		private TextBox textBox2;
		private Button buttonAuth;
		private TextBox textBox4;
		private TextBox textBox5;
		private Label label2;
		private Label label3;
		private ListBox listBox1;
		private Label labelAuth;
		private TabPage Logs;
		private TextBox textBox1;
		private Button buttonSended;
		private Button buttonRecived;
		private ListBox listBox2;
		private Label label4;
		private Label label5;
	}
}