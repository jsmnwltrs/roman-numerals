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

        public int RomanNumeralToNumber(string romanNum)
        {
            var result = 0;

            //reverse Roman numeral input
            var charArray = romanNum.ToCharArray();
            Array.Reverse(charArray);

            List<int> firstNumberList = new List<int>();
            List<int> secondNumberList = new List<int>();
           
            //convert roman numerals to numbers and add to a list
            foreach (var letter in charArray)
            {
                foreach (var kvp in RomanNumsDic)
                {
                    if (letter.ToString() == kvp.Value)
                    {
                        firstNumberList.Add(kvp.Key);
                        secondNumberList.Add(kvp.Key);
                    }
                } 
            }

            result = firstNumberList[0];

            //compare numbers in lists to account for instances like 4 and 9
            for (var i = 0; i < firstNumberList.Count; i++)
            {
                var index = i + 1;
                
                if (index == secondNumberList.Count)
                {
                    break;
                }
                else if (firstNumberList[i] > secondNumberList[index])
                {
                    result -= secondNumberList[index];
                }
                else
                {
                    result += secondNumberList[index];
                }
            }

            return result;
        }

    }
}
