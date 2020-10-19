using Microsoft.VisualBasic;

using System;
using System.Collections.Generic;
using System.IO;

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

        public static byte ToHex(byte input)
        {
            string Hex = input.ToString("X");
            return byte.Parse(Hex);
        }

        static void Main(string[] args)
        {

            char charA = 'a';
            int askiA = charA;

            var result1 = AskiTranslation("I Like to eat pizza all day");
            var result2 = AskiDecoder(result1);
            //Console.WriteLine($"{AskiTranslation("I Like to eat pizza all day")}");
            //Console.WriteLine($"{AskiDe)}");  

            string filename = @"\\gmrdc1\Folder Redirection\Mikah.Kainen\Desktop\cpppractice\main.cpp";
            byte[] fileBytes = File.ReadAllBytes(filename);

            int index;
            string Hex;
            int extra = fileBytes.Length % 16;
            for (int i = 0; i < fileBytes.Length / 16; i ++)
            {
                for (int x = 0; x < 16; x++)
                {
                    index = i * 16 + x;
                    Hex = fileBytes[index].ToString("X");
                    if (Hex.Length > 1)
                    {
                        Console.Write($"{Hex} ");
                    }
                    else
                    {
                        Console.Write($"0{Hex} ");
                    }
                }
                Console.Write("   ");

                for (int x = 0; x < 16; x++)
                {
                    index = i * 16 + x;
                    if (fileBytes[index] > 32)
                    {
                        Console.Write($"{(char)fileBytes[index]} ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            for(int i = fileBytes.Length - extra; i < fileBytes.Length; i ++)
            {
                
            }

            ;
        }
    }
}
