using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock Paper and Scissors";

            Class1 class1 = new Class1();
            class1.Randomizer();

            Looper loop = new Looper();
            loop.repeat();
        }
    }
}