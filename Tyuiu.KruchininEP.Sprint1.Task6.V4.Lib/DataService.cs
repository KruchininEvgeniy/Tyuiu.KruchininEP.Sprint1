using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KruchininEP.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] values = value.Split(' ');
            string res = "";
            foreach (string s in values)
            {
                if (s.Contains("нн")) res += s + " ";
            }
            return res.Trim();
        }
    }
}