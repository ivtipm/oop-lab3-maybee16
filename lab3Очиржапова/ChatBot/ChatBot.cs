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
                richTextBox_messages.Text += s + "\r\n\r\n";
                richTextBox_messages.Text += rpl.MessageReply(s) + "\r\n\r\n";
            }
            textBox_messages.Clear();
        }

        private void RichTextBox_messages_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_messages.Clear();
        }

        private void SaveHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFile.FileName, richTextBox_messages.Text);
        }

        private void DownloadHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = ofd.FileName;
                        string file = System.IO.File.ReadAllText(filename);
                        richTextBox_messages.Text = file;
                    }
                    else
                    {
                        richTextBox_messages.AppendText("Не удалось загрузить историю");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
