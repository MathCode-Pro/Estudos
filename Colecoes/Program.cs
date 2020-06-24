using System;
using System.Collections.Generic;

namespace Colecoes {
    class Program {
        static void Main(string[] args) {

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < 3; i++) {

                int alunos = 0;

                switch (i) {

                    case 0:
                        Console.Write("How many students for course A?");
                        alunos = int.Parse(Console.ReadLine());
                        break;

                    case 1:
                        Console.Write("How many students for course B?");
                        alunos = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("How many students for course C?");
                        alunos = int.Parse(Console.ReadLine());
                        break;

                    default:
                        break;
                }

                for(int j =0; j < alunos; j++) {

                    set.Add(int.Parse(Console.ReadLine()));
                }
            }

            Console.WriteLine("Total students: "+set.Count);
        }
    }
}
