using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class ChatBot : Form
    {
        Autorization frm;
        Reply rpl = new Reply();
        string s;
        public ChatBot(Autorization frm1)
        {
            InitializeComponent();
            frm = frm1;
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
                richTextBox_messages.Text += frm.textBox_name.Text + "  " + s + "\r\n\r\n";
            }
            textBox_messages.Clear();

        }

        private void RichTextBox_messages_TextChanged(object sender, EventArgs e)
        {
            richTextBox_messages.Text += rpl.MessageReply(s) + "\r\n\r\n";
        }
    }
}
