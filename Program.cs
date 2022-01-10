using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_22_Asynchronous
{
    // Разработать асинхронный метод для вычисления факториала числа.
    // В методе Main выполнить проверку работы метода.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);

            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            double s = 1;
            for (int i = 2; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine("Факториал числа равен: " + s);
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
