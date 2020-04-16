using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_33
{
    class Program
    {
        static void Main(string[] args)
        {
            //1050 - DDD

            Dictionary<string, string> dic = new Dictionary<string, string>();

            string Chavao = Console.ReadLine();

            dic.Add("61", "Brasilia");
            dic.Add("71", "Salvador");
            dic.Add("11", "Sao Paulo");
            dic.Add("21", "Rio de Janeiro");
            dic.Add("32", "Juiz de Fora");
            dic.Add("19", "Campinas");
            dic.Add("27", "Vitoria");
            dic.Add("31", "Belo Horizonte");

            if (dic.ContainsKey(Chavao))
            {
                Console.WriteLine(dic[Chavao]);
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            Console.ReadLine();

        }
    }
}
