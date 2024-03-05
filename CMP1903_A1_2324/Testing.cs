using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        private int _diceSum;
        private int _dieRoll;

        //Method
        public void TestDieRoll()
        { 
            Die die = new Die();

            die.Roll();
            _dieRoll = die.Roll();

            Debug.Assert(_dieRoll >=1  && _dieRoll <=6, "Invalid die roll, out of range");
            
        }
        public void TestDiceSum()
        {
            Game game = new Game();

            game.DiceSum();
            _diceSum = game.DiceSum();

            Debug.Assert(_diceSum >= 3 && _diceSum <= 18, "Invalid dice sum, out of range");
        }

    }
}
