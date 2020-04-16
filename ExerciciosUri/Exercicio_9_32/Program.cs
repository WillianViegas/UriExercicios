using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_32
{
    class Program
    {
        static void Main(string[] args)
        {
            //1049 - Animal

            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();


            if (palavra1.Equals("vertebrado"))
            {
                if (palavra2.Equals("ave"))
                {
                    if (palavra3.Equals("carnivoro"))
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (palavra3.Equals("onivoro"))
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (palavra2.Equals("inseto"))
                {
                    if (palavra3.Equals("hematofago"))
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (palavra3.Equals("hematofago"))
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
