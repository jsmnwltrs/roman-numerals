using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralGenerator
    {
        Dictionary<int, string> RomanNumsDic = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };
        public string NumberToRomanNumeral(int number)
        {

            var result = "";
            var counter = number;

            foreach (var kvp in RomanNumsDic)
            {
                while(counter >= kvp.Key)
                {
                    result += kvp.Value;
                    counter -= kvp.Key;
                }
            }
            return result;
        }

    }
}
