using System;
using System.Globalization;
using System.IO;

namespace Arquivos {
    class Program {
        static void Main(string[] args) {

            string[] products = new string[4];
            string path = @"c:\Users\guerr\Desktop";
            string arquiveName = "venda.txt";
            string outputPath = path + "\\out";
            string outputArquiveName = "summary.csv";

            try {

                if (!File.Exists(path + "\\" + arquiveName)) {

                    Console.WriteLine("Digite o nome do produto, preço unitário e quantidade separados por vírgula:");

                    for (int i = 0; i < products.Length; i++) {

                        products[i] = Console.ReadLine();
                    }

                    using (StreamWriter sr = File.CreateText(path + "\\" + arquiveName)) {

                        foreach (string line in products) {

                            sr.WriteLine(line);
                        }
                    }
                }

                if (!Directory.Exists(outputPath)) {

                    Directory.CreateDirectory(outputPath);
                }

                if (!File.Exists(outputPath + "\\" + outputArquiveName)) {

                    using StreamWriter sw = File.CreateText(outputPath + "\\" + outputArquiveName);
                }

                using (FileStream fs = new FileStream(path + "\\" + arquiveName, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {

                        while (!sr.EndOfStream) {

                            string[] line = sr.ReadLine().Split(',');

                            double unValue = double.Parse(line[1],CultureInfo.InvariantCulture);
                            int qtd = int.Parse(line[2].Trim());

                            double totalValue = unValue * qtd;

                            using StreamWriter sw = File.AppendText(outputPath + "\\" + outputArquiveName);

                            sw.WriteLine(line[0] + "," + totalValue.ToString("F2",CultureInfo.InvariantCulture));

                        }
                    }
                }

            } catch (IOException e) {

                Console.WriteLine("Exception: " + e.Message);
            }


        }
    }
}
