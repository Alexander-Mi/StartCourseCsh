using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
          // Мишанкин А

          //  1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
          //  а) используя склеивание;
          //  б) используя форматированный вывод;
          //  в) используя вывод со знаком $.


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
            Console.WriteLine(name + surname + height + weight);
            Console.WriteLine(" Имя " + name + " Фамилия " + surname + " Рост " + height + " Вес " + weight);
            Console.WriteLine($" Имя: { name}, Фамилия: { surname}, Рост: { height}, Вес: { weight}");
        }
    }
}
