namespace ChatBot
{
    partial class ChatBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_messages = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.richTextBox_messages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_messages
            // 
            this.textBox_messages.Location = new System.Drawing.Point(12, 336);
            this.textBox_messages.Name = "textBox_messages";
            this.textBox_messages.Size = new System.Drawing.Size(776, 22);
            this.textBox_messages.TabIndex = 1;
            this.textBox_messages.TextChanged += new System.EventHandler(this.TextBox_messages_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(687, 375);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(101, 29);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // richTextBox_messages
            // 
            this.richTextBox_messages.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_messages.Name = "richTextBox_messages";
            this.richTextBox_messages.ReadOnly = true;
            this.richTextBox_messages.Size = new System.Drawing.Size(776, 295);
            this.richTextBox_messages.TabIndex = 0;
            this.richTextBox_messages.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_messages);
            this.Controls.Add(this.richTextBox_messages);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_messages;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.RichTextBox richTextBox_messages;
    }
}