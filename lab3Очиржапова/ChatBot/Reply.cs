using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
