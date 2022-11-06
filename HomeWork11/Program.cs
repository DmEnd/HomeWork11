using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.   Разработать структуру для решения линейного уравнения 0=kx+b.
             * Коэффициенты уравнения k, b реализовать с помощью полей
             * вещественного типа. Для решения уравнения предусмотреть метод Root.
             * Создать экземпляр разработанной структуры. Осуществить использование
             * экземпляра в программе.
             */
            Console.Write("Введите коэффициент k уравнения 0=kx+b. k = ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b уравнения 0=kx+b. b = ");
            double b= Convert.ToDouble(Console.ReadLine());

            LinEquation linEq=new LinEquation(k, b);
            linEq.Root();
            Console.ReadKey();
        }
    }
}
