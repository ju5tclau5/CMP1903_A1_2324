using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.

        //Properties

        private int _total;   //holds the total of all die values added
        private int _value1;  //holds the die value for die 1
        private int _value2;  //holds the die value for die 2
        private int _value3;  //holds the die value for die 3

        //Methods

        //creates three die objects and assigns each of them a random value (1 - 6)
        public void RollDice()
        {
            Die die1 = new Die(); //creates die objects using the die class
            Die die2 = new Die();
            Die die3 = new Die();
            _value1 = die1.Roll(); //assigns each die value a random value using the .Roll() method
            _value2 = die2.Roll();
            _value3 = die3.Roll();
        }

        //sums all three dice objects up and returns the total
        public int DiceSum() 
        {
            RollDice();
            _total = (_value1 + _value2 + _value3); //assigns the _total variable the values of all three die
            return _total;
        }

        //writes each die value and the total value of the dice to the console and reads it
        public void DisplayDice() 
        {
            DiceSum();
            Console.WriteLine($"Die1 rolled {_value1}, Die2 rolled {_value2}, Die3 rolled {_value3}, Your total is = {_total}");
            Console.ReadLine();
        }


    }
}
