using System;
using System.Globalization;
using Her_Ex02.Entities;
using System.Collections.Generic;
namespace Her_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of products: "); int n = int.Parse(Console.ReadLine());
            List<Product> listP = new List<Product>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:" );
                Console.Write("Common, used or imported (c/u/i)? "); char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Price: "); double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(productType == 'c')
                {
                    Product product = new Product(name, price);
                    listP.Add(product);
                }
                else if(productType == 'i')
                {
                    Console.Write("Customs fee: "); double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct importedP = new ImportedProduct(name, price, customsFee);
                    listP.Add(importedP);
                }
                else if(productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): "); DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct usedP = new UsedProduct(name, price, date);
                    listP.Add(usedP);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in listP)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
