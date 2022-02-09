using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            // Test();
            // Console.WriteLine("Main is finished");
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            // Console.WriteLine("Factorial is started");
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                //Thread.Sleep(100);
            }
            Console.WriteLine("Факториал равен {0}", f);
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }

        //static void Test()
        //{
        //    Console.WriteLine("Test is started");
        //    for (int i = 1; i < 10; i++)
        //    {
        //        Console.WriteLine(i);
        //        Thread.Sleep(100);
        //    }
        //    Console.WriteLine("Test is finished");
        //}
    }

}
