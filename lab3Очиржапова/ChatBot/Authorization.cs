using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Authorization
    {
        string name;
        public void SetName(string n)
        {
            //if (n == "")
            //    throw Exception;
            name = n;
        }
        public string GetName()
        {
            return name;
        }
    }
}
