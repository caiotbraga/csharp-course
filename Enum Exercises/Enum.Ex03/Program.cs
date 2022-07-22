using System;
using Enum_Ex03.Entities;
namespace Enum_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice trip!");
            Comments c2 = new Comments("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("06/21/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComments(c1);
            p1.AddComments(c2);

            Comments c3 = new Comments("Good Night");
            Comments c4 = new Comments("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("07/28/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
        }
    }
}
