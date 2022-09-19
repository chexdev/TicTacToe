using System;
using static System.Console;

namespace TicTacToe
{
    class Player
    {
        private static string[] playerType = {"Human", "Computer Random", "Computer Alpha Beta" };
        private static char[] playerCode = {'1', '2', '3' }; 
        private string[] PlayerType { get; set; }
        public int[] PlayerCode { get; set; }
        public static int playerNum = 1; 

        public static void SetupPlayers()
        {
            //User selects play against Other Human (1), Computer Random (2), or Computer Alpha Beta (3).  
            //Display list of opponent codes
            DisplayOpponentCodes(); 
            //Prompt continuously for valid playerCode entered until Q entered to Quit
            const char QUIT = 'Q';
            char inputOpponentCode;
            Write("\nWho would you like to play against? Enter an opponent code (1, 2, or 3) to play against, or {0} to quit>> ", QUIT);

            inputOpponentCode = Convert.ToChar(ReadLine());

            while (inputOpponentCode != QUIT)
            {
                //check for matching code
                for (int i=0; i< playerCode.Length; i++)
                {
                    if (inputOpponentCode == playerCode[0]) //play against Other Human
                    {
                        //Assign User as Player 1 (Other Human is Player 2) 
                        Write("\nYou are Player {0}", playerNum);
                        Write("\nYour {0} opponent is Player {1}", playerType[i], playerNum += 1);
                        Human.HumanPlayer(); 
                        break; 
                    } else if (inputOpponentCode == playerCode[1]) //play against Computer Random
                    {
                        //Assign User as Player 1 (Other Human is Player 2) 
                        Write("\nYou are Player {0}", playerNum);
                        Write("\nYour {0} opponent is Player {1}", playerType[i], playerNum += 1);
                        ComputerRandom.ComputerRandomPlayer(); 
                        break; 
                    } else 
                    {
                        //Assign User as Player 1 (Other Human is Player 2) 
                        Write("\nYou are Player {0}", playerNum);
                        Write("\nYour {0} opponent is Player {1}", playerType[i], playerNum += 1);
                        ComputerAlphaBeta.ComputerAlphaBetaPlayer();
                        break; 
                    }
                }

            }

        }
        public static void DisplayOpponentCodes()
        {
            WriteLine(""); 
            WriteLine("\nOpponent codes are:");
            WriteLine("Enter Code:\t1\tto play against Other Human");
            WriteLine("Enter Code:\t2\tto play against Computer Randome");
            WriteLine("Enter Code:\t3\tto play against Computer Alpha Beta");
        }
    }

    class Human: Player
    {
        public static void HumanPlayer()
        {
            StandardMessages.Continue(); 
            GameEngine.MakeMoves();
        }
    }
    class ComputerRandom: Player
    {
        public static void ComputerRandomPlayer()
        {
            StandardMessages.Continue();
            //Add Random AI - to do


        }

    }
    class ComputerAlphaBeta: Player
    {
        public static void ComputerAlphaBetaPlayer()
        {
            StandardMessages.Continue();
            //Add Alpha Beta AI - to do 

        }
    }
}
