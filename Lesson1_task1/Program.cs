// Мишанкин А
using System;

namespace lesson1_task1
{
    class Program
    {
        static void Main(string[] args)
        {
             // вводим данные
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Вашe фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите Ваш рост, в метрах например 185,5");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Ваш вес в кг, например 75,5");
            double weight = Convert.ToDouble(Console.ReadLine());

            // выводим данные разными способами (Задание 1)
            Console.WriteLine("---------------");
            Console.WriteLine(name+surname+height+weight);
            Console.WriteLine(" Имя " + name + " Фамилия " + surname + " Рост " + height + " Вес " + weight);
            Console.WriteLine($" Имя: { name}, Фамилия: { surname}, Рост: { height}, Вес: { weight}");

            //считаем и индекс массы тела (задание 2)
            Console.WriteLine("---------------");
            double bmi = (weight / (height * height));
            Console.WriteLine($"Индекс массы тела:{bmi}");

            // задание 3. Подсчитаем расстояние между точками

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
