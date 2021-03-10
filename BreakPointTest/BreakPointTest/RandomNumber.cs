using System;
using System.Collections.Generic;
using System.Text;

namespace BreakPointTest
{
    class RandomNumber
    {
        private double secretNumber;

        public void generateNumber()
        {
            Random rand = new Random();
            secretNumber = rand.NextDouble()*100;
        }

        public int checkAnswear(double number)
        {
            if (number > secretNumber)
            {
                return 1;
            }
            else if (number < secretNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
