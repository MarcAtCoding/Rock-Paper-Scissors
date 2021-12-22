using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Class1
    {
        public void Randomizer()
        {
            bool playAgain = true;
            //scores
            int playerScore = 0;
            int compScore = 0;
            //randomizer
            int rndInt = 0;
            //inputs
            string plyrInp, compInp;

            while (playAgain)
            {
                Console.WriteLine("Hello!");
                while (playerScore < 3 && compScore < 3)
                {
                    Console.Write("\nChoose between rock, paper, and scissors: ");
                    plyrInp = Console.ReadLine();
                    plyrInp = plyrInp.ToUpper();

                    Random random = new Random();
                    rndInt = random.Next(1, 4);
                    switch (rndInt)
                    {
                        case 1:
                            compInp = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (plyrInp == "PAPER")
                            {
                                Console.WriteLine("Player scored!");
                                playerScore++;
                            }
                            else if (plyrInp == "ROCK")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (plyrInp == "SCISSORS")
                            {
                                Console.WriteLine("Computer scored!");
                                compScore++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                            break;
                        case 2:
                            compInp = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (plyrInp == "SCISSORS")
                            {
                                Console.WriteLine("Player scored!");
                                playerScore++;
                            }
                            else if (plyrInp == "PAPER")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (plyrInp == "ROCK")
                            {
                                Console.WriteLine("Computer scored!");
                                compScore++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                            break;
                        case 3:
                            compInp = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (plyrInp == "PAPER")
                            {
                                Console.WriteLine("Computer scored!");
                                compScore++;
                            }
                            else if (plyrInp == "SCISSORS")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (plyrInp == "ROCK")
                            {
                                Console.WriteLine("Player scored!");
                                playerScore++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                    if (playerScore == 3)
                    {
                        Console.WriteLine("\n-----YOU WIN!-----");
                        Console.WriteLine("Your Score: " + playerScore);
                        Console.WriteLine("Computer Score: " + compScore);
                    }
                    else if (compScore == 3)
                    {
                        Console.WriteLine("\n-----YOU LOSE-----");
                        Console.WriteLine("Your Score: " + playerScore);
                        Console.WriteLine("Computer Score: " + compScore);
                    }
                }
                if (playerScore == 3 || compScore == 3)
                {
                    Looper loop = new Looper();
                    loop.repeat();
                }
            }
        }
    }
}
