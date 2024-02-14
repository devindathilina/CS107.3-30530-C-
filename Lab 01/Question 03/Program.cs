using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quection_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                if (num>0)
                {
                    sum += 1;
                }
                else
                {
                    Console.WriteLine("ERROE");
                }
            }
            Console.WriteLine("The total is ");
            Console.ReadLine();
        }
    }
}
