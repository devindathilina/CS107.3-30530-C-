using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quection_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Ten Numbers");
            Console.WriteLine();

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"Enter Number {i}: "); 
                int number = Convert.ToInt32(Console.ReadLine());
                String result = (number%2==0)?"even":"odd" ;
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
