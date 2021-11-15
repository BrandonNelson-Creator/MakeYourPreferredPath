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
            Story();
            ReadKey(true);
        }

        static void Story()
        {
            

            string input = " ";
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

        static void NamePlayer()
        {
            WriteLine("Whats your name?");
            player = ReadLine();

            WriteLine("Great! " + player + ", Let's Begin.");

        }


        
    }
}
