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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBot));
            this.textBox_messages = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.richTextBox_messages = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_messages
            // 
            this.textBox_messages.Location = new System.Drawing.Point(0, 351);
            this.textBox_messages.Name = "textBox_messages";
            this.textBox_messages.Size = new System.Drawing.Size(652, 22);
            this.textBox_messages.TabIndex = 1;
            this.textBox_messages.TextChanged += new System.EventHandler(this.TextBox_messages_TextChanged);
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.LightPink;
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_send.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send.ForeColor = System.Drawing.Color.DarkRed;
            this.button_send.Location = new System.Drawing.Point(658, 347);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(130, 39);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // richTextBox_messages
            // 
            this.richTextBox_messages.BackColor = System.Drawing.Color.Pink;
            this.richTextBox_messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_messages.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_messages.ForeColor = System.Drawing.Color.Green;
            this.richTextBox_messages.Location = new System.Drawing.Point(0, 25);
            this.richTextBox_messages.Name = "richTextBox_messages";
            this.richTextBox_messages.ReadOnly = true;
            this.richTextBox_messages.Size = new System.Drawing.Size(800, 316);
            this.richTextBox_messages.TabIndex = 0;
            this.richTextBox_messages.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearChatToolStripMenuItem,
            this.saveHistoryToolStripMenuItem,
            this.downloadHistoryToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 28);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // clearChatToolStripMenuItem
            // 
            this.clearChatToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.clearChatToolStripMenuItem.Name = "clearChatToolStripMenuItem";
            this.clearChatToolStripMenuItem.Size = new System.Drawing.Size(287, 28);
            this.clearChatToolStripMenuItem.Text = "Очистить чат";
            this.clearChatToolStripMenuItem.Click += new System.EventHandler(this.ClearChatToolStripMenuItem_Click);
            // 
            // saveHistoryToolStripMenuItem
            // 
            this.saveHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.saveHistoryToolStripMenuItem.Name = "saveHistoryToolStripMenuItem";
            this.saveHistoryToolStripMenuItem.Size = new System.Drawing.Size(287, 28);
            this.saveHistoryToolStripMenuItem.Text = "Сохранить историю чата";
            this.saveHistoryToolStripMenuItem.Click += new System.EventHandler(this.SaveHistoryToolStripMenuItem_Click);
            // 
            // downloadHistoryToolStripMenuItem
            // 
            this.downloadHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.downloadHistoryToolStripMenuItem.Name = "downloadHistoryToolStripMenuItem";
            this.downloadHistoryToolStripMenuItem.Size = new System.Drawing.Size(287, 28);
            this.downloadHistoryToolStripMenuItem.Text = "Загрузить историю чата";
            this.downloadHistoryToolStripMenuItem.Click += new System.EventHandler(this.DownloadHistoryToolStripMenuItem_Click);
            // 
            // ChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_messages);
            this.Controls.Add(this.richTextBox_messages);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChatBot";
            this.Text = "Mr. Bot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_messages;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadHistoryToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox_messages;
    }
}