using ConsoleApp_PromotionEngine.Model;
using ConsoleApp_PromotionEngine.Service;
using System;
using System.Collections.Generic;

namespace ConsoleApp_PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            
           List<Product> products = new List<Product>();

            Console.Write("How many orders?=> ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("{0} - Enter the type of product:A,B,C or D=> ",i+1);
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }
            Calculation c = new Calculation();
            int totalPrice = c.GetTotalPrice(products);
            Console.WriteLine("Total => {0}",totalPrice);
            Main(args);
            Console.ReadLine();
        }


    }
}
