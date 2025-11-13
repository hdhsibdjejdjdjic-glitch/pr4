using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Этап 1: Ввод значения параметра x
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            
            // На этом этапе программа просто ждет ввода
            Console.WriteLine("Ввод завершен. Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}