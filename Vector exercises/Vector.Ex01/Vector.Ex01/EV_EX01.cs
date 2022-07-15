using System;

namespace EV_EX01 {
    internal class Program {
        static void Main(string[] args) {

            int n, number;
            string name, email;

            Room[] rooms = new Room[10];

            Console.WriteLine("How many rooms will be rented?");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                if (rooms[i] != null) {
                    Console.WriteLine("This room is busy!");
                }
                else {
                    Console.WriteLine($"Rent {i + 1}");
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Email:");
                    email = Console.ReadLine();
                    Console.WriteLine("Number:");
                    number = int.Parse(Console.ReadLine());
                    //rooms[i] = new Room(name, email, number);
                    rooms[number] = new Room { Name = name, Email = email};
                }   
            }
            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < 10; i++) {
                if (rooms[i] != null) {
                    Console.WriteLine(i +":" + rooms[i]);
                }
            }
            
        }

    }
}
