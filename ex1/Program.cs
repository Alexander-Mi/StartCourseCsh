using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин А
            // Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = minimum(a, b, c);

            Console.WriteLine($"Миниальное число: {d}");

        }

        private static int minimum(int a, int b, int c)
        {
            int d; // Минимальная переменная 

            if (a < b && a < c) d = a;
            else if (b < c) d = b;
            else d = c;
            return d;
        }

    }
}

