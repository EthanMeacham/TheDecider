using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheDecider {
    class Program {
        static void Main(string[] args) {
            System.IO.StreamReader list = new System.IO.StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "list.txt");
            Random rand = new Random();

            //Get number of lines and random number
            var lineCount = File.ReadLines(@AppDomain.CurrentDomain.BaseDirectory + "list.txt").Count();
            int r = rand.Next(1, lineCount + 1);
            Console.WriteLine(r);
            
            // Skip random number of lines
            for (var i = 1; i < r; i++) {
                list.ReadLine();
            }

            //Display next line after skipped lines
            Console.WriteLine(list.ReadLine());

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}