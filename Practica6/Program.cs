using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            
            double F = 3 * Math.Sin(x + 2);
            
            Console.WriteLine($"Для значения х = {x}, F = {F}.");
            Console.WriteLine("Нажмите любую клавишу ");
            Console.ReadKey();
        }
    }
}