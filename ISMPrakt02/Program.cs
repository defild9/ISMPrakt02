using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a  = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d:");
            double d = Convert.ToDouble(Console.ReadLine());

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            double y = (5 * (a + b) * (c - b)) / (1 / 2 * c) + d * d * (a * a - b * b) / (b - a);
            double z = (((x * x - 2 * x) - 4 * (x * x * x * x + 1)) * (1 - b)) / (5 * a + 3 * b);
            double r = (1/2*a+3/4*b-7/5)/(3*c+1)+ 1 / (a - c);
            Console.Write($"x = {x}, y = {y}, z ={z}, r = {r}  ");
        }
    }
}
