using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dictionary {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, int> votes = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");

            using (StreamReader sr = File.OpenText(Console.ReadLine())) {

                while (!sr.EndOfStream) {
                    string[] s = sr.ReadLine().Split(',');

                    if (!votes.ContainsKey(s[0]))
                        votes.Add(s[0], int.Parse(s[1]));
                    else
                        votes[s[0]] += int.Parse(s[1]);
                }

                foreach (KeyValuePair<string, int> k in votes) {

                    Console.WriteLine(k.Key + ": " + k.Value);
                }
            }
        }
    }
}
