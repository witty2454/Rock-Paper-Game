using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Game
{
    public class GameRules
    {
        //member varibles (can do)
        
        
        //constuctor


        //member methods (has a)

        public void DisplayRules ()
        {
            List<string> Rules = new List<string>();
            Rules.Add("Rock crushes Scissors");
            Rules.Add("Scissors cuts Paper");
            Rules.Add("Paper covers Rock");
            Rules.Add("Rock crushes Lizard");
            Rules.Add("Lizard poisons Spock");
            Rules.Add("Spock smashes Scissors");
            Rules.Add("Scissors decapitates Lizard");
            Rules.Add("Lizard eats Paper");
            Rules.Add("Paper disproves Spock");
            Rules.Add("Spock vaporizes Rock");
            
                foreach(string item in Rules)
            
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
