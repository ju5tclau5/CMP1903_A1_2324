using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //The Die class should contain one property to hold the current die value and one method that rolls the die, returns and integer and takes no parameters

        //Properties
        private static Random random = new Random(); //holds a random number from the random class
        private int _dieValue; //holds the rolled die value

        //Method

        //rolls a random number and assigns it to _dieValue
        public int Roll() 
        {
            _dieValue = random.Next(1, 7); //rolls a number between 1 and 7, including 1
            return _dieValue;              //and assigns it to _dieValue
        }

    }
}
