using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;
            if (D == 0)
            {
                 x1 = -b / (2 * a);
                 Console.WriteLine($"x ={x1}");
            }
            else
            {
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
                }
                Console.WriteLine("Уравнение не имеет значений");
            }
        }
    }
}
