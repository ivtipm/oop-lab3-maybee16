using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Calculator
    {
        string pattern = @"(\d+)\s+([-+*/])\s+(\d+)";
        string result;

        public Calculator()
        {
            result = "";
        }
        public string Calculate(string expr)
        {
            foreach (var expressions in expr)
                foreach (System.Text.RegularExpressions.Match m
                    in System.Text.RegularExpressions.Regex.Matches(expr, pattern))
                {
                    double value1 = Double.Parse(m.Groups[1].Value);
                    double value2 = Double.Parse(m.Groups[3].Value);
                    switch (m.Groups[2].Value)
                    {
                        case "+":
                            return result = m.Value + " = " + Convert.ToString(value1 + value2);
                        case "-":
                            return result = m.Value + " = " + (value1 - value2);
                        case "*":
                            return result = m.Value + " = " + (value1 * value2);
                        case "/":
                            return result = m.Value + " = " + (value1 / value2);
                    }
                }
            return result = "Введите выражение";
        }
    }
}
