using System;
using Scrabble;

namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();
            Console.WriteLine(Game.CheckCharPoints(input));
        }
    }
}