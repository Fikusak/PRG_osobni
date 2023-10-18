using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] numbers = { 10, 20, 30, 40, 50 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Výpis for cyklem");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Výpis foreach");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Suma: " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum/numbers.Length;
            Console.WriteLine("Průměr: " +  average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + max);
            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = numbers.Min();
            Console.WriteLine("Minimum: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int num = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(numbers, num);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    index = i;
                    break;
                }
            }
            if(index == -1)
            {
                Console.WriteLine("Prvek v poli neexistuje");
            }
            else
            {
                Console.WriteLine($"Prvek {num} je na indexu {index}");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rng = new Random();
            numbers = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = rng.Next(0, 10); //interval <0, 10)
                Console.WriteLine($"{i}. prvek pole je {numbers[i]}");
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            foreach(int number in numbers)
            {
                counts[number]++;
            }
            for(int i = 0; i < counts.Length;i++)
            {
                Console.WriteLine($"Četnost {i} je {counts[i]}");
            }
            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            Console.ReadKey();
        }
    }
}
