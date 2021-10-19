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

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a,2)/ Math.Pow(b,2);
            double y = (5 * (a + b) * (c - b)) / (1 / 2 * c) + Math.Pow(d,2)* (Math.Pow(a,2) - Math.Pow(b,2)) / (b - a);
            double z = ((Math.Pow((Math.Pow(x,2) - 2 * x),3) - 4 * (Math.Pow(x,4)+ 1)) * (1 - b)) / (5 * a + 3 * b);
            double r = (1.00/2*a+3.00/4*b-7.0/5)/(3*c+1)+ 1 / (a - c);
            Console.Write($"x = {x}, y = {y}, z ={z}, r = {r}  ");
        }
    }
}
