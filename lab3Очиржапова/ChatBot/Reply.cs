using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChatBot
{
    public class Reply
    {
        string rpl;
        public Reply()
        {
            rpl = "";
        }
        public string MessageReply(string m)
        {
            m = m.ToLower();
            if (m.Contains("привет"))
                return rpl = "Здравствуй!";
            if (m.Contains("как дела"))
                return rpl = "Отлично!";
            if (m.Contains("который час"))
                return DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString();
            if (m.Contains("какое сегодня число"))
                return DateTime.Now.Day.ToString();
            if (m.Contains("какой сейчас месяц"))
                return DateTime.Now.Month.ToString();
            if (m.Contains("какой сейчас год"))
                return DateTime.Now.Year.ToString();
            if (m.Contains("какая сейчас дата"))
                return DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            if (m.Contains("какой сейчас день недели"))
                return DateTime.Now.DayOfWeek.ToString();
            if (m.Contains("реши"))
            {
                Calculator calc = new Calculator();
                string pattern = @"[реши]\s";
                string[] elements = System.Text.RegularExpressions.Regex.Split(m, pattern);
                foreach (var element in elements)
                    rpl = element;
                return calc.Calculate(rpl);
            }
            if (m.Contains("погода") || m.Contains("новости") || m.Contains("курс") || m.Contains("что такое") || m.Contains("найди"))
            {
                SearchQuery(m);
                return $"Открываю поиск по запросу '{m}'";
            }
            return "Я вас не понимаю!";
        }
        private void SearchQuery(string m)
        {
            System.Diagnostics.Process.Start("https://yandex.ru/search/?text=" + m);
        }

        public void SaveHistory(ChatBot c)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFile.FileName, c.richTextBox_messages.Text);
        }

        public void DownloadHistory(ChatBot c)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = ofd.FileName;
                        string file = System.IO.File.ReadAllText(filename);
                        c.richTextBox_messages.Text = file;
                    }
                    else
                    {
                        c.richTextBox_messages.AppendText("Не удалось загрузить историю");
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
