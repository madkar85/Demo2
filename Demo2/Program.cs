﻿using System;
using System.Linq;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+k, ctrl+d för att refactor koden
            //Ett sätt
            int[] arrayOfNumbers = new int[5];
            arrayOfNumbers[0] = 13;
            arrayOfNumbers[1] = 22;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 93;
            arrayOfNumbers[4] = 1;


            Console.WriteLine("Check if you picked a lucky number");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (myNr == arrayOfNumbers[i])
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Not this time");
                }

            }

            Console.WriteLine(arrayOfNumbers.Contains(3));
        }
    }
}
