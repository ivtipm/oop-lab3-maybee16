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
            if (m == "привет!")
                return rpl = "Здравствуй!";
            if (m == "как дела?")
                return rpl = "Отлично!";
            if (m == "который час?")
                return DateTime.Now.TimeOfDay.ToString();
            if (m == "какое сегодня число?")
                return DateTime.Now.Day.ToString();
            if (m == "какой сейчас месяц?")
                return DateTime.Now.Month.ToString();
            if (m == "какой сейчас год?")
                return DateTime.Now.Year.ToString();
            if (m == "какая сейчас дата?")
                return DateTime.Now.Date.ToString();
            if (m == "какой сейчас день недели?")
                return DateTime.Now.DayOfWeek.ToString();
           
                Calculator calc = new Calculator();

                return calc.Calculate(m);
            
            //return "Я вас не понимаю!";
        }
    }
}
