using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int sum1 = 0; //диагональ 1//
            int sum2 = 0; //диагональ 2//
            int sum3 = 0; //сумма всех чисел//
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    sum3 += a; //сумма всех чисел, всегда будет равна сумме всех столбцов и всех строк//
                    if (i == j) //считаем диагонали//
                    {
                        sum1 += a;
                    }
                    if (i == n - j - 1)
                    {
                        sum2 += a;
                    }
                }
            }
            if (sum1 == sum2 && sum1 == sum3 / n)
            {
                Console.WriteLine("Матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Матрица НЕ является магическим квадратом");
            }
            Console.ReadKey();
        }
    }
}
