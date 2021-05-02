using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин А

            // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ)
            // по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

               // вводим данные
               Console.WriteLine("Введите Ваш рост, в метрах например 185,5");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Ваш вес в кг, например 75,5");
            double weight = Convert.ToDouble(Console.ReadLine());

            //считаем и индекс массы тела (задание 2)
            Console.WriteLine("---------------");
            double bmi = (weight / (height * height));
            Console.WriteLine($"Индекс массы тела:{bmi}");
        }
    }
}
