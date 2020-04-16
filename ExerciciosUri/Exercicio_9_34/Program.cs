using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_34
{
    class Program
    {
        static void Main(string[] args)
        {
            //1052 - Mês

            Dictionary<string, string> dic = new Dictionary<string, string>();

            string numero = Console.ReadLine();

            dic.Add("1", "January");
            dic.Add("2", "February");
            dic.Add("3", "March");
            dic.Add("4", "April");
            dic.Add("5", "May");
            dic.Add("6", "June");
            dic.Add("7", "July");
            dic.Add("8", "August");
            dic.Add("9", "September");
            dic.Add("10", "October");
            dic.Add("11", "November");
            dic.Add("12", "December");


            if (dic.ContainsKey(numero))
            {
                Console.WriteLine(dic[numero]);
            }

            Console.ReadLine();
        }
    }
}
