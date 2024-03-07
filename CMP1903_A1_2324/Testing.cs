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
        //This class should test the Die and the Game class.

        private int _dieRoll; //holds the invidiual die roll value to be tested
        private int _diceSum; //holds the sum of three die values to be tested

        //Method

        //tests to see that when dice are rolled that they are within the range of 1-6
        public void TestDieRoll()
        { 
            Die die = new Die();

            die.Roll();
            _dieRoll = die.Roll();

            Debug.Assert(_dieRoll >=1  && _dieRoll <=6, "Invalid die roll, out of range"); //if die roll is out of bounds, it will abort the program and pop an error up
            
        }

        //tests to see that when each die is added up that it is within the range of 3-18
        public void TestDiceSum()
        {
            Game game = new Game();

            game.DiceSum();
            _diceSum = game.DiceSum();

            Debug.Assert(_diceSum >= 3 && _diceSum <= 18, "Invalid dice sum, out of range"); //if the sum of dice is less than 3 or more than 18 then it will abort the program and pop an error up
        }

    }
}
