using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var romanNumeral = Console.ReadLine();
            var romanToNumber = new RomanNumeralGenerator();
            romanToNumber.RomanNumeralToNumber(romanNumeral);
            Console.ReadLine();

        }
    }
}
