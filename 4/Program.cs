using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int k = 0;
            for (int j = 1; j < n; j += 2)
            {
                if (array[j] > 0)
                {
                    if (array[j] % 2 != 0)
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
