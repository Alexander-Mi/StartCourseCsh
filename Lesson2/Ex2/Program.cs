using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин А
            // 2.Написать метод подсчета количества цифр числа.

            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = counter(a);

            Console.WriteLine(b);

        }

        private static int counter(int a)
        {
            int b = 0; // хранит количество цифр 
            if (a == 0) b = 1;
            while (a != 0)
            {
                a = a / 10;
                b++;
            }

            return b;
        }
    }
}
