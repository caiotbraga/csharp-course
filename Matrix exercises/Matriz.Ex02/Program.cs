 using System;

namespace Mat_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Insert the line and coloumns respectively:");
            string[] order = Console.ReadLine().Split(' ');
            int l = int.Parse(order[0]);
            int c = int.Parse(order[1]);

            int[,] matrix = new int[l, c];
            
            for (int i = 0; i < l; i++) {
                string[] vallue = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    matrix[i, j] = int.Parse(vallue[j]);
                }
            }

            Console.WriteLine("Insert a number (x) that belongs to the matrix created:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (matrix[i, j] == x) {
                        Console.WriteLine("Position {"+i+","+j+"}:");
                        if(j > 0) {
                            Console.WriteLine($"Left:{matrix[i, j - 1]}");
                        }
                        if(i > 0) {
                            Console.WriteLine($"Up:{matrix[i - 1, j]}");
                        }
                        if (j < c - 1) {
                            Console.WriteLine($"Right:{matrix[i, j + 1]}");
                        }
                        if (i < l - 1) {
                            Console.WriteLine($"Down:{matrix[i + 1, j]}");
                        }
                    }
                }
            }

        }
    }
}
