using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChatBot
{
    public partial class ChatBot : Form
    {
        Autorization frm = new Autorization();
        Reply rpl = new Reply();
        string s;
        public ChatBot(Autorization frm1)
        {
            InitializeComponent();
            frm = frm1;
        }

        public ChatBot()
        {

        }

        private void TextBox_messages_TextChanged(object sender, EventArgs e)
        {
            s = textBox_messages.Text;
        }

        private void Button_send_Click(object sender, EventArgs e) //отправка сообщения
        {
            if (textBox_messages.Text == "")
                richTextBox_messages.Text += "Вы пытаетесь отправить пустое сообщение" + "\r\n\r\n";
            else
            {
                UserMessage();
                BotMessage();
            }
            richTextBox_messages.ScrollToCaret();
            textBox_messages.Clear();
        }

        private void ClearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_messages.Clear();
        }

        private void SaveHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpl.SaveHistory(this);
        }

        private void DownloadHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpl.DownloadHistory(this);
        }

        private void UserMessage()
        {
            string n = frm.TextBox_name.Text;
            var startOfSelection = richTextBox_messages.TextLength;
            richTextBox_messages.AppendText(n);
            richTextBox_messages.Select(startOfSelection, n.Length);
            richTextBox_messages.SelectionColor = Color.Red;
            richTextBox_messages.Text += "  " + s + "\r\n\r\n";
        }

        private void BotMessage()
        {
            string n = "Mr.Bot";
            var startOfSelection = richTextBox_messages.TextLength;
            richTextBox_messages.AppendText(n);
            richTextBox_messages.Select(startOfSelection, n.Length);
            richTextBox_messages.SelectionColor = Color.Blue;
            richTextBox_messages.Text += "  " + rpl.MessageReply(s) + "\r\n\r\n";
        }
    }
}
