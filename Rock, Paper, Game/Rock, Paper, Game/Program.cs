using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //member varibles (can do)


            //constuctor

            GameRules gameRules = new GameRules();
            gameRules.DisplayRules();
            Player human = new Human();
            human.PickGesture();
            Console.ReadLine();

              
            //member methods (has a)
        }
    }
}
