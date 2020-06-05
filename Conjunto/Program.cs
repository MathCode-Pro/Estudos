using System;
using System.Collections.Generic;

namespace Conjunto {
    class Program {
        static void Main() {

            List<string> cursos;
            HashSet<int> codAlunos = new HashSet<int>();

            Console.Write("Digite os nomes dos seus cursos separados por um espaço: ");
            cursos = new List<string>(Console.ReadLine().Split(' '));

            for (int i = 0; i < cursos.Count; i++) {

                Console.Write($"O curso {cursos[i]} possui quantos alunos? ");
                int qtdAlunos = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite os códigos dos alunos do curso {cursos[i]}:");

                for (int j = 0; j < qtdAlunos; j++) {

                    int codigo = int.Parse(Console.ReadLine());

                    if (!codAlunos.Contains(codigo))
                        codAlunos.Add(codigo);
                }
            }

            Console.WriteLine("Total de alunos: " + codAlunos.Count);
        }
    }
}
