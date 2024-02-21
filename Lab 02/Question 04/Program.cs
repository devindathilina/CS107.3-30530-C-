using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    class product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product("EarBuds", 400.59m);
            product product2 = new product("Mouse", 102.33m);
            product product3 = new product("JBL", 600.89m);


            Console.WriteLine("Product Details:");
            Console.WriteLine("-----------------");
            Console.WriteLine("*****************");
            DisplayProductDetails(product1);
            Console.WriteLine("#################");
            DisplayProductDetails(product2);
            Console.WriteLine("#################");
            DisplayProductDetails(product3);

            Console.ReadLine();

        }
        static void DisplayProductDetails(product product)
        {
            {
                Console.WriteLine($"Product Name: {product.ProductName}");
                Console.WriteLine($"Price: ${product.Price:F2}");
                Console.WriteLine();
            }
        }
    }
}
