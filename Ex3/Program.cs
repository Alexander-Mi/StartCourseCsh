using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин А
            // а) Написать программу, которая подсчитывает расстояние между точками с
            // координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            // Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            int x1, x2, y1, y2;
            x1 = 2;
            x2 = 5;
            y1 = 2;
            y2 = 120;
            double r = Convert.ToDouble(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine($"Расстояние между точками: { r:F2}");
        }
    }
}
