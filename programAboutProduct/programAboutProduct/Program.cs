using System;
using System.Collections.Generic;
using programAboutProduct.Entities;

namespace programAboutProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(); 

            Console.Write("Enter the number of products: ");
            int numberOfProduct = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfProduct; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tipeOfProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (tipeOfProduct)
                {
                    case 'c':
                        products.Add(new Product(name, price));

                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new usedProduct(name, price, manufactureDate));

                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        products.Add(new importedProduct(name, price, customsFee));

                        break;

                    default:
                        return;
                }
                                
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product produ in products)
            {
                Console.WriteLine(produ.priceTag());
            }

        }
    }
}
