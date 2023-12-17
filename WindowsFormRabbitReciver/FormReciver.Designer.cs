namespace WindowsFormRabbitReciver
{
	partial class FormReciver
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
			listBox1 = new ListBox();
			textBox3 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			textBox2 = new TextBox();
			tabControl1.SuspendLayout();
			auth.SuspendLayout();
			chat.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(auth);
			tabControl1.Controls.Add(chat);
			tabControl1.Location = new Point(12, 8);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(485, 473);
			tabControl1.TabIndex = 12;
			// 
			// auth
			// 
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
			label3.Location = new Point(117, 142);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(117, 38);
			label2.Name = "label2";
			label2.Size = new Size(75, 20);
			label2.TabIndex = 3;
			label2.Text = "Username";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(114, 162);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(125, 27);
			textBox5.TabIndex = 2;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(114, 68);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(125, 27);
			textBox4.TabIndex = 1;
			// 
			// buttonAuth
			// 
			buttonAuth.Location = new Point(145, 246);
			buttonAuth.Name = "buttonAuth";
			buttonAuth.Size = new Size(94, 29);
			buttonAuth.TabIndex = 0;
			buttonAuth.Text = "Accedi";
			buttonAuth.UseVisualStyleBackColor = true;
			// 
			// chat
			// 
			chat.Controls.Add(listBox1);
			chat.Controls.Add(textBox3);
			chat.Controls.Add(label1);
			chat.Controls.Add(button1);
			chat.Controls.Add(textBox2);
			chat.Location = new Point(4, 29);
			chat.Name = "chat";
			chat.Padding = new Padding(3);
			chat.Size = new Size(477, 440);
			chat.TabIndex = 1;
			chat.Text = "Chat";
			chat.UseVisualStyleBackColor = true;
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
			label1.Location = new Point(69, 69);
			label1.Name = "label1";
			label1.Size = new Size(22, 20);
			label1.TabIndex = 12;
			label1.Text = "A:";
			// 
			// button1
			// 
			button1.Location = new Point(379, 348);
			button1.Name = "button1";
			button1.Size = new Size(31, 29);
			button1.TabIndex = 14;
			button1.Text = ">";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(66, 348);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(307, 27);
			textBox2.TabIndex = 13;
			// 
			// FormReciver
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(506, 480);
			Controls.Add(tabControl1);
			Name = "FormReciver";
			Text = "FormReciver";
			tabControl1.ResumeLayout(false);
			auth.ResumeLayout(false);
			auth.PerformLayout();
			chat.ResumeLayout(false);
			chat.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage auth;
		private Label label3;
		private Label label2;
		private TextBox textBox5;
		private TextBox textBox4;
		private Button buttonAuth;
		private TabPage chat;
		private ListBox listBox1;
		private TextBox textBox3;
		private Label label1;
		private Button button1;
		private TextBox textBox2;
	}
}