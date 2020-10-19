using System;
using System.Collections.Generic;

namespace AsciTranslation
{
    class Program
    {
        public static int[] AskiTranslation(string input)
        {
            int[] returnArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                returnArray[i] = input[i];
            }
            return returnArray;
        }

        public static char[] AskiDecoder(int[] input)
        {
            char[] returnArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                returnArray[i] = (char)input[i];
            }
            return returnArray;
        }
        static void Main(string[] args)
        {
            char charA = 'a';
            int askiA = charA;

            var result1 = AskiTranslation("I Like to eat pizza all day");
            var result2 = AskiDecoder(result1);
            //Console.WriteLine($"{AskiTranslation("I Like to eat pizza all day")}");
            //Console.WriteLine($"{AskiDe)}");
            ;
        }
    }
}
