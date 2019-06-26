using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Game
{
    class AIPlayer : Player
    {
        //member varibles (can do)
        string CompName;

        //constuctor

         public  void Computer()
        {
            Console.WriteLine("Enter your Computer Name?");
            this.CompName = Console.ReadLine();

        }
        

        //member methods (has a)
    }
}
