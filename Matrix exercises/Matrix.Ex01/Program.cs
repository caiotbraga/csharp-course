using System;

namespace Mat_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            
            int n, i, j, countN = 0;
            int v;
            Console.WriteLine("Enter the matrix's order:");
            n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for(i = 0; i < n; i++) {
                string[] vallue = Console.ReadLine().Split(' ');
                for (j = 0; j < n; j++) {
                    matrix[i,j] = int.Parse(vallue[j]);
                }
            }
            Console.WriteLine("Main diagonal:");
            for(i = 0; i < n; i++) {
                Console.WriteLine(matrix[i,i]+" ");
            }

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (matrix[i,j] < 0) {
                        countN++;
                    }
                }
            }

            Console.WriteLine($"Negative numbers: {countN}");


        }
    }
}
