using System;
using Enum_Ex04.Entities.Enums;
using Enum_Ex04.Entities;
using System.Globalization;
namespace Enum_Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name:"); string clientName = Console.ReadLine();
            Console.Write("Email:"); string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY)"); DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Clients client = new Clients(clientName, email, birthDay);

            Console.WriteLine("Enter order data:");
            Console.Write("Status:"); OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order?"); int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name:"); string nameP = Console.ReadLine();
                Console.Write("Product price:"); double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(nameP, price);    
                Console.Write("Quantity:"); int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
