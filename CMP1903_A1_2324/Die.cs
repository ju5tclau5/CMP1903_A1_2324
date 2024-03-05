using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
 
        //Property
        private int _dieValue; //holds the rolled die value
        private static Random random = new Random();

        //Method

        //rolls a random number and assigns it to dieValue
        public int Roll() 
        {
            _dieValue = random.Next(1, 7); //rolls a number between 1 and 7, including 1
            return _dieValue;              //and assigns it to dieValue
        }

    }
}
