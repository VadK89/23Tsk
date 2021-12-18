using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _23Tsk
{
    class Program
    {
        //Метод вычисления факториала
        static void Factorial(int fac)
        {
            int Snum = 1;
            for (int i = 1; i <= fac; i++)
            {
                Snum *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine($"Факториал числа равен {Snum}");
        }
        //Асинхронный метод для запуска метода  вычисления факториала
        static async void FacAsync(int num)
        {
            Console.WriteLine("Начинает работу асинхронный метод для запуска вычисления факториала");
            await Task.Run(()=>Factorial(num));
            Console.WriteLine("Завершил работу асинхронный метод для запуска вычисления факториала");
        }
        //Метод вычисления суммы чисел
        static void ArProg(int ar)
        {
            int Sum = 0;
            for (int i = 0; i <= ar; i++)
            {
                Sum += i;
                Thread.Sleep(200);
            }
            Console.WriteLine($"Сумма чисел от 0 до {ar} равна {Sum}");
        }
        static void Main(string[] args)
        {
            //Задаем число
            Console.WriteLine("Введите число от 1 до 19");
            int f = Convert.ToInt32(Console.ReadLine());
            //Запускаем методы и получаем результат
            Task task = Task.Run(() => ArProg(f));
            FacAsync(f); 
            Console.ReadKey();
        }

    }
}
