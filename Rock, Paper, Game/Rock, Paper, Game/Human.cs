using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Game
{
    class Human : Player
    {
        //member varibles (can do)
        string PlayerName;
        

        //constuctor
        public Human()
        {
            Console.WriteLine("Enter your name?");
            this.PlayerName = Console.ReadLine();

        }

        public void PickGesture(){
            Console.WriteLine("Human");
        }
        
        //member methods (has a)

       
    }
}
