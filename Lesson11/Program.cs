using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для решение уравнения вида 0 = kx + b");
            Console.Write("Введите значение коэффициента k=");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента b=");
            double b = Convert.ToDouble(Console.ReadLine());

            LinearEquation equation = new LinearEquation(k,b);
            Console.WriteLine(equation.Root());
            Console.ReadKey();
        }
    }
}
