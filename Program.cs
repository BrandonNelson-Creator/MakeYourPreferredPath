using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MakeYourPreferredPath
{
    class Program
    {
        static string player;
        
        
        static void Main(string[] args)
        {
           

            WriteLine("Make Your Preferred Path");
            ReadKey(true);
            NamePlayer();
            RaceSelection();
            Story();
            ReadKey(true);
        }

        static void Story()
        {
            

            string input = "";
            WriteLine("Which path will you take? A or B?");
            input = ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                WriteLine(player + " You've chosen path A!");
                Beep();
            }
            if (input == "B")
            {
                WriteLine(player + " You've chosen path B!");
                Beep();
            }
                
        }

        //Name Player
        static void NamePlayer()
        {
            string input = "";
            WriteLine("Whats your name?");
            if (input == "")
            {
                WriteLine("Please enter a name");
            }
            player = ReadLine();

            WriteLine("Great! " + player + ", Let's Begin.");

        }

        //Race Slection
        static void RaceSelection()
        {
            string input = "";
            WriteLine("Choose your race!");
            WriteLine("HUMAN");
            WriteLine("ORC");
            WriteLine("ELF");
            WriteLine("CENTAUR");
            input = ReadLine();
            input = input.ToUpper();
            if (input == "")
            {
                WriteLine("Please enter a race");
                 WriteLine("Choose your race!");
            }
           
            if (input == "HUMAN")
            {
                WriteLine("You are a Human!");
                
            }
            if (input == "ORC")
            {
                WriteLine("You are a Orc!");
            }
            if (input == "CENTAUR")
            {
                WriteLine("Hmm Centaur... Interesting");

            }



        }



    }
}
