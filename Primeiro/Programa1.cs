using SalarioFunc;
using System;
using System.Globalization;
namespace Primeiro {
    class Programa1 {
        static void Main(string[] args) {

            Retangulo retangulo;

            retangulo = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + retangulo.Area());
            Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro());
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal());
        }

    }

}
