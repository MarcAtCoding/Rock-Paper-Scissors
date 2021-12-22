using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Looper
    {
        public void repeat()
        {
            Console.Write("\nWould you like to play again (y/n): ");
            string anotherRound = Console.ReadLine();
            if (anotherRound == "y")
            {
                Console.Clear();
                Class1 copy = new Class1();
                copy.Randomizer();
            }
            else if (anotherRound == "n")
            {
                Console.WriteLine("\nThank you for playing.");
                Console.WriteLine("Press any key() to close this program.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
