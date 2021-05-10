using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин А
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) Сделать задание, только вывод организовать в центре экрана.
            // в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Мишанкин Александр Калининград");
        }
    }
}
