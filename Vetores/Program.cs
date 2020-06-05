using System;

namespace Vetores {
    class Program {
        static void Main(string[] args) {
            Quartos[] quartos;
            int rooms = 0;

            while (true) {

                quartos = new Quartos[10];

                Console.Write("How many rooms will be rented? ");
                rooms = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (rooms <= 10 && rooms > 0) {

                    string name;
                    string email;
                    int numQuarto = 0;
                    int cont = 0;
                    for (int i = 1; i <= rooms; i++) {

                        Console.WriteLine("Rent #" + i);

                        Console.Write("Name: ");
                        name = Console.ReadLine();

                        Console.Write("Email: ");
                        email = Console.ReadLine();

                        Console.Write("Room: ");
                        numQuarto = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (numQuarto <= 10 && numQuarto > 0) {

                            quartos[numQuarto] = new Quartos { Nome = name, Email = email, Quarto = numQuarto };
                            cont++;

                        } else {
                            Console.WriteLine("Quarto inexistente!");
                            break;
                        }
                    }

                    if (cont == rooms)
                        break;

                    Console.WriteLine();

                } else {
                    Console.WriteLine("Existem somente 10 quartos disponíveis!");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Busy rooms:");

            for (int y = 0; y <= quartos.Length; y++) {

                if (quartos[y].Quarto != 0)
                    Console.WriteLine(quartos[y]);
            }
        }
    }
}
