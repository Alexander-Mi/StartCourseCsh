using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин а
            // 3. С клавиатуры вводятся числа, пока не будет введен 0.
            // Подсчитать сумму всех нечетных положительных чисел.


            int summa = ex3();

            Console.WriteLine(summa);
        }

        private static int ex3()
        {
            int summa = 0;

            while (true)
            {
                Console.WriteLine("Введите число ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) break;
                if (a > 0 && a % 2 == 1) summa += a;
            }

            return summa;
        }
    }
}
