using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeLine("Press any key to start");
            Console.ReadKey();
            Console.Clear();
            TypeLine("You are a mercenary. You are going to an abandoned uranium mine because the locals from a near village were complaining about unhuman screams coming from there\n");
            TypeLine("Choose your character\n");
            
            string answer = Console.ReadLine();
            void TypeLine(string value)
            {
                Thread.Sleep(1000);
                foreach (var letter in value)
                {
                    Console.Write(letter);
                    Thread.Sleep(100);
                }
                Console.WriteLine();  
            }
            Console.ReadKey();
        }
        
    }
}
