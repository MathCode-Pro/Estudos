using System;
using System.Runtime.CompilerServices;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            string[] length = Console.ReadLine().Split(' ');

            int[,] mat = new int[int.Parse(length[0]), int.Parse(length[1])];

            for (int i = 0; i < mat.GetLength(0); i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++) {

                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {

                    if (mat[i, j] == value) {

                        Console.WriteLine($"Position: {i},{j}");

                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);

                        if (j < mat.GetLength(1) - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);

                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);

                        if (i < mat.GetLength(0) - 1)

                            Console.WriteLine("Down: " + mat[i + 1, j]);


                    }
                }
            }
        }
    }
}
