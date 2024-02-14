using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quection_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Calculete the area of Rectangle");
            Console.WriteLine();
            Console.WriteLine("Enter length");
            double length =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            double width = Convert.ToDouble(Console.ReadLine());    

            double area = length * width;

            Console.WriteLine($"The area is: {area}");
            Console.ReadLine();


        }
    }
}
