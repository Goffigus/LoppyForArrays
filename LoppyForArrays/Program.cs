using System;
using static System.Console;

namespace LoppyForArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //<type>[<declares array] = new <same type> [<size>]
            string[] input = new string[10];

            string[] otherInput = { "rock", "rock", "rock" }; //another way to create an array

            //for loop (variable declaration/being set; loop consition; iterating process)
            for (int counter = 0; counter < 3; counter++)
            {
                input[counter] = ReadLine();
                Clear();
            }

            //can declare variable 'counter' again because prev one was only made and used in prev for loop
            for (int counter = 2; counter >= 0; counter--)
            {
                WriteLine("Player{0} chose {1}", counter + 1, input[counter]);
            }
        }
    }
}
