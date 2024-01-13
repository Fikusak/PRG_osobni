using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Game
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            int myHealth;
            int eHealth;
            int myDamage;
            int eDamage;
            string myCharacter;

            TypeLine("Press any key to start");
            Console.ReadKey();
            Console.Clear();
            TypeLine("You are a mercenary. You are going to an abandoned sulfur mine because the locals from a near village were complaining\nabout unhuman screams coming from there\n");
            TypeLine("Choose your character\n1 - Stalker - You can sneak past some enemies\n2 - Dozer - You can block the first attack of your enemy");
            int choice = Convert.ToInt32(Console.ReadLine());
            myHealth = 0;
            myDamage = 0;
            myCharacter = "";
            if (choice == 1)
            {
                Stalker stalker = new Stalker("Stalker", 80, 50);
                TypeLine("You are a " + stalker.Sname);
                myHealth = stalker.Shealth;
                myDamage = stalker.Sstrength;
                myCharacter = "stalker";
            }
            else if (choice == 2)
            {
                Dozer dozer = new Dozer("Dozer", 100, 50);
                TypeLine("You are a " + dozer.Dname);
                myHealth = dozer.Dhealth;
                myDamage = dozer.Dstrength;
                myCharacter = "dozer";
            }
            else
            {
                TypeLine("Invalid input");
                TypeLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
                
            Enemies possesed = new Enemies("Possesed", 60, 30);
            eHealth = possesed.Ehealth;
            eDamage = possesed.Estrength;

            TypeLine("You went in, after a few first steps in the dark you see a miner. When he turns around and faces you, you realize that\nhe isdefinitely not a human anymore.");
            TypeLine("You have " + myHealth + " health");
            TypeLine("Enemy has " + eHealth + " health");
            TypeLine("Write 'attack' to attack the enemy");

            string actionChoice = Console.ReadLine();
            if (actionChoice == "attack")
            {
                 Fight();
            }
            Console.Clear();
            eHealth = possesed.Ehealth;
             
            TypeLine("You continue on your journey. As you go deeper to the mine it gets hotter and hotter. You hear more growling and distantscreams. One scream is right from behind a corner of a mineshaft in fornt of you. You peek there and see another\n'possesed' eating a corpse. What do you do?");
            TypeLine("You have " + myHealth + " health");
            TypeLine("Enemy has " + eHealth + " health");
             
            if (myCharacter == "stalker")
            {
                 TypeLine("Write 'attack' or 'sneak'");
            }
            else
            {
                 TypeLine("Write 'attack'");

            }
            actionChoice = Console.ReadLine();

            if(actionChoice == "attack" && myCharacter == "stalker")
            {
                 Fight();
            }
            else if (actionChoice == "attack" && myCharacter == "dozer")
            {
                 dFight();
            }
            else
            {
                 TypeLine("You have snuck past the enemy");
            }
            Console.Clear();
            Enemies hellRam = new Enemies("Hell Ram", 120, 45);
            eHealth = hellRam.Ehealth;
            eDamage = hellRam.Estrength;

            TypeLine("You go down a steep hill of mined rocks. The heat still rises and the screams still come closer. You stumbled over a\nrock and slid down to a big mined out space. " +
                 "As you dust yourself off a pair of big red horns catches your eye. " +
                 "You heara roar, the two horned moster rams towards you.");
            TypeLine("Quickly press 'e' to dodge it");
            DateTime endTime = DateTime.Now.AddSeconds(7);
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.E)
                    {
                        TypeLine("\nYou have dodged it");
                        break;                    
                    }
                
                }
                if (DateTime.Now > endTime)
                {
                     Console.Clear();
                     TypeLine("\nYou were pierced by it´s horns");
                     TypeLine("Press any key to exit");
                     Console.ReadKey();
                     Environment.Exit(0);
                }
            }

            TypeLine("You see a sharp piece of rail on the ground. You have to stab it to weaken it.");

            TypeLine("Quickly press 'f' to stab it");
            
            DateTime endTime2 = DateTime.Now.AddSeconds(7);
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.F)
                    {
                         TypeLine("\nYou have stabbed it into it´s back");
                         eHealth -= 20;
                         break;
                    }
                }
                if (DateTime.Now > endTime)
                {
                     Console.Clear();
                     TypeLine("\nYou failed to injure it. Now it is too strong.");
                }
            }
            Console.Clear();
          
            TypeLine("You have " + myHealth + " health");
            TypeLine("Enemy has " + eHealth + " health");
          
            if (myCharacter == "stalker")
            {
                 Fight();
            }
            else
            {
                 dFight();
            }
            if (myHealth > 0)
            {
                TypeLine("You won this fight. You go further to the center of the big mined room. As you get to the center a piece of floor falls down. " +
                "You see people getting tortured, red from the flames but not as red nor as scary as the demon staring you into\nyour eyes. You run in pure fear but the floor is collapsing behind you, in front of you and now below you...");
            }
            else
            TypeLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
            void Fight()                                                    //voidy pro fighty
            {
                eHealth -= myDamage;
                TypeLine("You attacked for " + myDamage + " damage");
                while (eHealth > 0 && myHealth > 0)
                {
                    myHealth -= eDamage;
                    TypeLine("Enemy attacked for " + eDamage + " damage");
                    if (myHealth <= 0)
                        { break; }
                    eHealth -= myDamage;
                    TypeLine("You attacked for " + myDamage + " damage");
                   
                }
                if (myHealth < 0) 
                    TypeLine("You died.");
                else
                    TypeLine("Enemy has been defeated. You have " + myHealth + " health left");
            }
            void dFight()
            {
                eHealth -= myDamage;
                TypeLine("You attacked for " + myDamage + " damage");
                TypeLine("You have blocked an attack");
                eHealth -= myDamage;
                while (eHealth > 0 && myHealth > 0)
                {
                    TypeLine("You attacked for " + myDamage + " damage");
                    if (eHealth <= 0)
                        { break; }
                    myHealth -= eDamage;
                    TypeLine("Enemy attacked for " + eDamage + " damage");
                }
                if (myHealth <= 0)
                    TypeLine("You died.");
                else
                    TypeLine("Enemy has been defeated. You have " + myHealth + " health left");
            }
            
            void TypeLine(string value)   //void pro rychlost textu
            {
                Thread.Sleep(70);
                foreach (char letter in value)
                {
                    Console.Write(letter);
                    Thread.Sleep(70);
                }

                Console.WriteLine();  
            }
            Console.ReadKey();
        }
        
    }
}
