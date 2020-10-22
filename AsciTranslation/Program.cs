using Microsoft.VisualBasic;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            int ZeroCount = 6;

            string filename = @"../../../main.cpp";
            byte[] fileBytes = File.ReadAllBytes(filename);

            string collumn;
            for(int i = 0; i < ZeroCount + 1; i ++)
            {
                Console.Write(" ");
            }
            for(int i = 0; i < 16; i ++)
            {
                collumn = i.ToString("X");
                Console.Write($"0{collumn} ");
            }
            Console.WriteLine("   DECODED TEXT");

            int index;
            string Hex;
            int extra = fileBytes.Length % 16;
            string row;
            for (int i = 0; i < fileBytes.Length / 16; i++)
            {
                row = i.ToString("X");
                for(int x = row.Length; x < ZeroCount; x ++)
                {
                    Console.Write("0");
                }
                Console.Write($"{row} ");
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

            row = (fileBytes.Length/16).ToString("X");
            for (int x = row.Length; x < ZeroCount; x++)
            {
                Console.Write("0");
            }
            Console.Write($"{row} ");
            for (int i = fileBytes.Length - extra; i < fileBytes.Length; i ++)
            {
                Hex = fileBytes[i].ToString("X");
                if (Hex.Length > 1)
                {
                    Console.Write($"{Hex} ");
                }
                else
                {
                    Console.Write($"0{Hex} ");
                }
            }
            Console.Write("+  ");
            for(int i = extra; i < 16; i ++)
            {
                Console.Write("   ");
            }
            for (int i = fileBytes.Length - extra; i < fileBytes.Length; i++)
            {
                if (fileBytes[i] > 32)
                {
                    Console.Write($"{(char)fileBytes[i]} ");
                }
                else
                {
                    Console.Write(". ");
                }
            }
            Console.WriteLine("+");

            ;
        }
    }
}
