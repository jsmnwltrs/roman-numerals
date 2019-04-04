using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralGenerator
    {
        public string NumberToRomanNumeral(int number)
        {
            var result = "";
            var counter = number;

            if (counter >= 9 && counter < 19)
            {
                counter-= 10;
                if (counter == -1)
                {
                    result += "I";
                }
                result += "X";
            }
          
            if (counter >= 4 && counter < 9)
            {
                counter = counter - 5;
                if (counter == -1)
                {
                    result += "I";
                }
                result += "V";
                while (counter > 0)
                {
                    result += "I";
                    counter -= 1;
                }
            }

            if (counter <= 3)
            {
                while (counter > 0)
                {
                    result += "I";
                    counter -= 1;
                }
            }
            return result;
        }

    }
}
