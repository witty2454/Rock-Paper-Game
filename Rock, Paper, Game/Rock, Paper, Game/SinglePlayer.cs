using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Game
{
    class SinglePlayer
    {
        static void SinglePlayer(string[] args)
        {
           string InputPlayer, InputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
                {
                int scorePlayer = 0;
                int scoreCPU = 0;
                
            while (scorePlayer < 3 && scoreCPU <3)
                {

            Console.WriteLine("Choose between Rock,Paper,Scissor,Spock,Lizard:    ");
            InputPlayer = Console.ReadLine();
            InputPlayer = InputPlayer.ToUpper();
            Random rnd = new Random();

            randomInt = rnd.Next(1,6);
            switch (randomInt)
            {
                case 1:
                    InputCPU ="Rock";
                    Console.WriteLine("Computer chose Rock");
                    if (InputPlayer =="Rock")
                        {
                        Console.WriteLine("Draw!!\n\n");
                        }
                    else if (InputPlayer == "Paper")
                        {
                        Console.WriteLine("Player Wins!!\n\n");
                        scorePlayer++;
                        }
                    else if (InputPlayer == "Scissor");
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                    }
                    break;
                case 2:
                    InputCPU ="Paper";
                     Console.WriteLine("Computer chose Paper");
                    if (InputPlayer =="Paper")
                        {
                        Console.WriteLine("Draw!!\n\n");
                        }
                    else if (InputPlayer == "Scissor")
                        {
                        Console.WriteLine("Player Wins!!\n\n");
                        scorePlayer++;
                        }
                    else if (InputPlayer == "Rock");
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                    }
                    break;
                case 3:
                    InputCPU = "Scissors";
                     Console.WriteLine("Computer chose Scissor");
                    if (InputPlayer =="Scissor")
                        {
                        Console.WriteLine("Draw!!\n\n");
                        }
                    else if (InputPlayer == "Spock")
                        {
                        Console.WriteLine("Player Wins!!\n\n");
                        scorePlayer++;
                        }
                    else if (InputPlayer == "Paper");
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                    }
                    break;
                case 4:
                    InputCPU ="Spock";
                    Console.WriteLine("Computer chose Spock");
                    if (InputPlayer =="Spock")
                        {
                        Console.WriteLine("Draw!!\n\n");
                        }
                    else if (InputPlayer == "Lizard")
                        {
                        Console.WriteLine("Player Wins!!\n\n");
                        scorePlayer++;
                        }
                    else if (InputPlayer == "Scissor");
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                    }
                    break;
                case 5:
                    InputCPU ="Lizard";
                      Console.WriteLine("Computer chose Lizard");
                    if (InputPlayer =="Lizard")
                        {
                        Console.WriteLine("Draw!!\n\n");
                        }
                    else if (InputPlayer == "Rock")
                        {
                        Console.WriteLine("Player Wins!!\n\n");
                        scorePlayer++;
                        }
                    else if (InputPlayer == "Spock");
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                    }
                    break;
                    Console.ReadLine();
                default:
                    Console.WriteLine("Invaild Entry");
                break;
                }
            }
            if (scorePlayer == 2)
                {
                Console.WriteLine("Player Won!");
                }
            else if (scoreCPU == 2)
                {
                Console.WriteLine("CPU WON!");
                }
            Console.WriteLine("Do you want to play again?(yes/no)");
            string loop = Console.ReadLine();
                if(loop == "yes")
                    {
                        playAgain = true;
                    }   
                else if (loop == "no")
                    {   
                    playAgain = false;
                    }
                else
                    {

                    }


        }
        }

    }
}
