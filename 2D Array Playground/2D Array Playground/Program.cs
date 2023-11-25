using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //U některých kódů jsem se nechal inspirovat na stránkách https://stackoverflow.com/,
            //https://www.itnetwork.cz, https://www.w3resource.com/ - využil jsem je k pochopení funkcí, žádné jsem přímo nekopíroval
            //a*b
            Console.WriteLine("Zadej počet řádků");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej počet sloupců");
            int s = Convert.ToInt32(Console.ReadLine());
            int[,] custom2DArray = new int[r, s];
            for (int i = 0; i < custom2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < custom2DArray.GetLength(1); j++)
                {
                    custom2DArray[i, j] = i * r + j + 1;
                    Console.Write($"{custom2DArray[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            Console.WriteLine("Co dál? Transpozice - 0, Násobení číslem - 1, Sčítání/Odčítání - 2, Násobení dvou matic - 3, Zbylé úlohy - 4");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            //Transpozice
            if (choice == 0)
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(custom2DArray[j, i] + " ");

                }
                Console.WriteLine();
            }
            
            //nasobeni cislem
            if (choice == 1)
            {
                    Console.WriteLine("Napiš číslo, kterým chceš matici vynásobit");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < custom2DArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < custom2DArray.GetLength(1); j++)
                        {
                            custom2DArray[i, j] = i * r * n + (j + 1) * n;
                            Console.Write($"{custom2DArray[i, j]} ");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine();
            }
            
            //scitani/odcitani
            if (choice == 2)
            {
                Console.WriteLine("Kolik chceš řádků?");
                int radky = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kolik chceš sloupců?");
                int sloupce = Convert.ToInt32(Console.ReadLine());
                int[,] matice1 = new int[radky, sloupce];
                Console.WriteLine("Zadej po jednom čísla první matice");
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        matice1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int[,] matice2 = new int[radky, sloupce];
                Console.WriteLine("Zadej po jednom čísla druhé matice");
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        matice2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int[,] maticeSoucet = new int[radky, sloupce];
                Console.WriteLine("Součet matic:");
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        maticeSoucet[i, j] = matice1[i, j] + matice2[i, j];
                        Console.Write(maticeSoucet[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int[,] maticeOdecet = new int[radky, sloupce];
                Console.WriteLine("Odečet matic:");
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        maticeOdecet[i, j] = matice1[i, j] - matice2[i, j];
                        Console.Write(maticeOdecet[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            //Násobení dvou matic
            if (choice == 3)
            {
                Console.WriteLine("Kolik chceš řádků 1. matice?");
                int radky = Convert.ToInt32(Console.ReadLine());
                int sloupce = radky;
                int[,] matice1 = new int[radky, sloupce];
                Console.WriteLine("Zadej po jednom čísla první matice");
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        matice1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int[,] matice2 = new int[radky, sloupce];
                Console.WriteLine("Zadej po jednom čísla druhé matice");
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        matice2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Součin matic:");
                int[,] maticeSoucin = new int[radky, sloupce];
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        maticeSoucin[i, j] = 0;
                        for (int k = 0; k < sloupce; k++)
                        {
                            maticeSoucin[i, j] += matice1[i, k] * matice2[k, j];
                        }
                    }
                }
                for (int i = 0; i < radky; i++)
                {
                    for (int j = 0; j < sloupce; j++)
                    {
                        Console.Write(maticeSoucin[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        

            //Další úlohy
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            if (choice == 4)
            {
                int[,] my2DArray = new int[5, 5];
                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        my2DArray[i, j] = i * 5 + j + 1;
                        Console.Write($"{my2DArray[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();

                //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
                int nRow = 1;
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[nRow, j] + " ");
                }
                Console.WriteLine("\n");

                //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
                int nColumn = 3;
                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    Console.Write(my2DArray[i, nColumn] + " ");
                }
                Console.WriteLine("\n");

                //Hlavní diagonála
                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    Console.Write(my2DArray[i, i] + " ");
                }
                Console.WriteLine("\n");

                //Vedlejší diagonála
                for (int i = my2DArray.GetLength(0) - 1; i >= 0; i--)
                {
                    Console.Write(my2DArray[i, my2DArray.GetLength(0) - 1 - i] + " ");
                }
                Console.WriteLine("\n");
                
                //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
                //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
                int xFirst = 0;
                int yFirst = 0;
                int xSecond = 4;
                int ySecond = 4;

                int temporary = my2DArray[xFirst, yFirst];
                my2DArray[xFirst, yFirst] = my2DArray[xSecond, ySecond];
                my2DArray[xSecond, ySecond] = temporary;

                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        Console.Write($"{my2DArray[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();

                //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
                int nRowSwap = 0;
                int mRowSwap = 1;
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    int temp = my2DArray[nRowSwap, j];
                    my2DArray[nRowSwap, j] = my2DArray[mRowSwap, j];
                    my2DArray[nRowSwap, j] = temp;
                }

                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        Console.Write($"{my2DArray[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();

                //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
                int nColSwap = 0;
                int mColSwap = 1;
                for (int i = 0; i < my2DArray.GetLength(1); i++)
                {
                    int temp = my2DArray[nColSwap, i];
                    my2DArray[nColSwap, i] = my2DArray[nColSwap, i];
                    my2DArray[mColSwap, i] = temp;
                }

                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        Console.Write($"{my2DArray[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();

                //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    int temp = my2DArray[i, i];
                    int coordToSwap = my2DArray.GetLength(0) - 1 - i;
                    my2DArray[i, i] = my2DArray[coordToSwap, coordToSwap];
                    my2DArray[coordToSwap, coordToSwap] = temp;
                }

                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        Console.Write($"{my2DArray[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();

                //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
                for (int i = my2DArray.GetLength(0) - 1; i >= my2DArray.GetLength(0) / 2; i--)
                {
                    int j = my2DArray.GetLength(0) - 1 - i;
                    int temp = my2DArray[i, j];
                    my2DArray[i, j] = my2DArray[j, i];
                    my2DArray[j, i] = temp;
                    Console.Write(my2DArray[i, j] + " ");
                }

                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        Console.Write($"{my2DArray[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
        
    }
}
