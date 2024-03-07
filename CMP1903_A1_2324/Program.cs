using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a Game object and call its methods. Creates a Testing object to verify the output and operation of the other classes.

            Testing testing = new Testing();
            testing.TestDieRoll(); //tests that each die value is within range
            testing.TestDiceSum(); //tests the the total value of dice is within range

            Game game = new Game();
            game.DisplayDice(); //displays each die value to the console aswell as the total sum
        }
    }
}
