using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int a = 0; a < n; a++)
            {
                if (a % 2 == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < n; j++)
                        if (j % 2 == 0)
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            Console.Write("1 ");
                        }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
