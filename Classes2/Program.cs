using System;

namespace Classes2 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine());

            aluno.N2 = double.Parse(Console.ReadLine());

            aluno.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2")); ;

            if (aluno.Aprovacao())
                Console.WriteLine("APORVADO");
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTAM  {aluno.Falta():F2} PONTOS");
            }
        }
    }
}
