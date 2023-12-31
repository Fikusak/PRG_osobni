﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */
            
            Console.WriteLine("Napiš číslo");
            string hodnota1;
            float cislo1;
            while (true)
            {
                hodnota1 = Console.ReadLine();
                if (float.TryParse(hodnota1, out float check) == true) //Vyzkousi jestli je to int/cislo
                {
                    cislo1 = float.Parse(hodnota1);
                    break; //jinak pise do nekonecna

                }
                else { Console.WriteLine("Číslo lopato"); }
            }        
                      
            Console.WriteLine("Napiš další číslo");
            string hodnota2;
            float cislo2;
            while (true)
            {
                hodnota2 = Console.ReadLine();
                if (float.TryParse(hodnota2, out float check) == true)
                {
                    cislo2 = float.Parse(hodnota2);
                    break; 

                }
                else { Console.WriteLine("Tak máš lobotomii či co"); }
            }
            Console.WriteLine("Teď napiš znaménko pro operaci (+ - * / ^)");   
            
            float result = 0;

            List<string> list = new List<string>() {"+", "-", "*", "/", "^" };
            while (true) 
            {
                string operace = Console.ReadLine();
                if (list.Contains(operace) == false)
                {
                    Console.WriteLine("Běž radši hrát wotko");  
                }
                    
                if (list.Contains(operace) == true)
                {
                    if (operace == "+")
                        result = (cislo1 + cislo2);
                    if (operace == "-")
                        result = (cislo1 - cislo2);
                    if (operace == "*")
                        result = (cislo1 * cislo2);
                    if (operace == "/")
                        result = (cislo1 / cislo2);
                    if (operace == "^")
                        result = ((int)Math.Pow(cislo1, cislo2));

                    Console.WriteLine("Výsledek je " + result);
                }
            }
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
