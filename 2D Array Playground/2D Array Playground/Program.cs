using System;
using System.Collections.Generic;
using System.Linq;
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
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).

            int[,] myArray = new int[5, 5];
            int numberToken = 1;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = numberToken;
                    numberToken++;
                    Console.WriteLine($"{myArray[i, j]}");
                    
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 1;
            for (int i = 0; j = myArray.GetLength(1); j++)
            {
                Console.WriteLine(myArray[nRow, j] + " ");
            }
            Console.WriteLine("\n");
            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 4; 
            int ySecond = 4;

            int temporary = myArray

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            for(int j = 0; j < myArray.GetLength(1); j++)
            {
                int temp = myArray[nRowSwap, j];
                myArray[nRowSwap, j] = myArray[mRowSwap, j];
                myArray[nRowSwap, j] = temp;
            }
            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                int temp = myArray[nColSwap, i];
                myArray[nColSwap, i] = myArray[nColSwap, i];
                myArray[nColSwap, i] = temp;
            }
            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                int temp = myArray[i, i];
                int coordToSwap = myArray.GetLength(0) - 1 - i;
                myArray[i, i] = myArray[coordToSwap, coordToSwap];
                myArray[coordToSwap, coordToSwap] = temp;
            }
            
            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = myArray.GetLength(0) - 1; i>=myArray.GetLength(0) / 2; i--)
			{
                int j = myArray.GetLength(0) - 1 - i;
                int temp = myArray[i, j];
                myArray[i, j] = myArray[j, i];
                myArray[j, i] = temp;
                Console.WriteLine(myArray[i, j] + " ");
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"{myArray[i, j]}");

                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
