using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissor
{
    class Program
    {
        static void Main(string[] args)
        {
            // What was chosen by Player
            string playerChoose, computerChoose;

            string welcomeMessage = "Rock-Paper-Scissors game";
            Console.WriteLine(welcomeMessage.ToUpper());

            // Asking player for continuing the game
            bool playAgain = true;

            while (playAgain)
            {
                // Tracking the score of Player and Computer
                int scorePlayer = 0; int scoreComputer = 0;

                Console.WriteLine("\r\nHow many times do you want to play against the Computer? ");
                Console.Write("Enter a number, please: ");
                // Reading the input and converting it to int
                string playingRounds = Console.ReadLine();
                int convertToInt = int.Parse(playingRounds);

                // Repeat the game as many times as the player entered
                for (int i = 0; i < convertToInt; i++)
                {
                    Console.WriteLine("\r\nROUND {0}", i + 1);
                    Console.Write("Rock, Paper or Scissors? ");
                    // Players choice
                    playerChoose = Console.ReadLine();

                    /* For Computer choose creating a random nr.
                     * between 1-4(4 is exclusive => so 1,2,3)
                     */
                    Random rnd = new Random();
                    int randomInt;
                    // rnd.Next(inclusive nr., exclusive nr.)
                    randomInt = rnd.Next(1, 4);

                    /* Checking which was "choosed" by computer
                     * and comparing to Players' choosed "weapon".
                     * And by the results incrementing the scores
                     */
                    switch (randomInt)
                    {
                        case 1:
                            computerChoose = "Rock";
                            Console.WriteLine("Computer: ROCK!");
                            if (playerChoose == "Rock")
                            {
                                Console.WriteLine("It's a DRAW! Both of you selected Rock! :)");
                            }
                            else if (playerChoose == "Paper")
                            {
                                Console.WriteLine("Player wins this round!");
                                // Upscale Players' score
                                scorePlayer++;
                            }
                            else if (playerChoose == "Scissors")
                            {
                                Console.WriteLine("Computer wins this round!");
                                // Upscale Computers' score
                                scoreComputer++;
                            }
                            break;

                        case 2:
                            computerChoose = "Paper";
                            Console.WriteLine("Computer: PAPER!");
                            if (playerChoose == "Paper")
                            {
                                Console.WriteLine("It's a DRAW! Both of you selected Paper! :)");
                            }
                            else if (playerChoose == "Scissors")
                            {
                                Console.WriteLine("Player wins this round!");
                                // Upscale Players' score
                                scorePlayer++;
                            }
                            else if (playerChoose == "Rock")
                            {
                                Console.WriteLine("Computer wins this round!");
                                // Upscale Computers' score
                                scoreComputer++;
                            }
                            break;

                        case 3:
                            computerChoose = "Scissors";
                            Console.WriteLine("Computer: SCISSORS!");
                            if (playerChoose == "Scissors")
                            {
                                Console.WriteLine("It's a DRAW! Both of you selected Scissors! :)");
                            }
                            else if (playerChoose == "Rock")
                            {
                                Console.WriteLine("Player wins this round!");
                                // Upscale Players' score
                                scorePlayer++;
                            }
                            else if (playerChoose == "Paper")
                            {
                                Console.WriteLine("Computer wins this round!");
                                // Upscale Computers' score
                                scoreComputer++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }

                if (scorePlayer > scoreComputer)
                {
                    Console.WriteLine("\r\nFINAL SCORES: Player {0} - Computer {1}. Player WON with {2} point(s)", scorePlayer, scoreComputer, scorePlayer);
                }
                else if (scorePlayer < scoreComputer)
                {
                    Console.WriteLine("\r\nFINAL SCORES: Player {0} - Computer {1}. Computer WON with {2} point(s)", scorePlayer, scoreComputer, scoreComputer);
                }
                else if (scorePlayer == scoreComputer)
                {
                    int oldScorePlayer = scorePlayer;
                    int oldScoreComputer = scoreComputer;

                    // If scores are equal, then +1 round
                    Console.WriteLine("\r\nDRAW! Let's have a last round!...");

                    Console.WriteLine("\r\nLAST FINAL ROUND");
                    Console.Write("Rock, Paper or Scissors? ");
                    playerChoose = Console.ReadLine();
                    Random rnd = new Random();

                    int randomInt;
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            computerChoose = "Rock";
                            Console.WriteLine("Computer: ROCK!");
                            if (playerChoose == "Rock")
                            {
                                Console.WriteLine("It's a DRAW! Both of you selected Rock! :)");
                            }
                            else if (playerChoose == "Paper")
                            {
                                Console.WriteLine("Player wins in this final round!");
                                scorePlayer++;
                            }
                            else if (playerChoose == "Scissors")
                            {
                                Console.WriteLine("Computer wins in this final round!");
                                scoreComputer++;
                            }
                            break;

                        case 2:
                            computerChoose = "Paper";
                            Console.WriteLine("Computer: PAPER!");
                            if (playerChoose == "Paper")
                            {
                                Console.WriteLine("It's a DRAW! Both of you selected Paper! :)");
                            }
                            else if (playerChoose == "Scissors")
                            {
                                Console.WriteLine("Player wins in this final round!");
                                scorePlayer++;
                            }
                            else if (playerChoose == "Rock")
                            {
                                Console.WriteLine("Computer wins in this final round!");
                                scoreComputer++;
                            }
                            break;

                        case 3:
                            computerChoose = "Scissors";
                            Console.WriteLine("Computer: SCISSORS!");
                            if (playerChoose == "Scissors")
                            {
                                Console.WriteLine("It's a DRAW! Both of you selected Scissors! :)");
                            }
                            else if (playerChoose == "Rock")
                            {
                                Console.WriteLine("Player wins in this final round!");
                                scorePlayer++;
                            }
                            else if (playerChoose == "Paper")
                            {
                                Console.WriteLine("Computer wins in this final round!");
                                scoreComputer++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    if (scorePlayer > scoreComputer)
                    {
                        Console.WriteLine("\r\nFINAL SCORES: Player {0} - Computer {1}. Player WON with {2} point(s)", scorePlayer, scoreComputer, scorePlayer);
                    }
                    else if (scorePlayer < scoreComputer)
                    {
                        Console.WriteLine("\r\nFINAL SCORES: Player {0} - Computer {1}. Computer WON with {2} point(s)", scorePlayer, scoreComputer, scoreComputer);
                    }
                    else if (scorePlayer == scoreComputer)
                    {
                        Console.WriteLine("It's a DRAW in the last round too. So let's stop here!... ");
                    }

                }
                playAgain = false;

                Console.Write("\r\nDo you want to play again?(Y/N): ");
                string startAgainTheGame = Console.ReadLine();

                if (startAgainTheGame == "N")
                {
                    playAgain = false;

                    /* Quit the .exe file when the user 
                    * pressed a key not after imediately
                    * the full game has ended
                    */
                    Console.WriteLine("Press any key to Quit...");
                    Console.ReadKey();
                }
                else if (startAgainTheGame == "Y")
                {
                    playAgain = true;
                    Console.WriteLine("Niiiice! Then let's play again! :)");
                }
            }
        }
    }
}
