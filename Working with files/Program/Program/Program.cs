using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; //@ serve pra nao precisar usar 2 barras (\\)
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
