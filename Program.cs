using System;
using HighLowGame.Models;

namespace HightLowGame
{
  class Program
  {
    private static string userInput;
    static void Main()
    {
      Console.WriteLine("Let's play a number guessing game.");
      Console.WriteLine("Pick a number between 1 and 100. Hit 'Y' to start.");
      userInput = Console.ReadLine().ToLower();
      if(userInput == "y")
      {
        Game.initialGuess();
        makeGuess();
      }
    }
    static void makeGuess()
    {
      Console.WriteLine("Is your number higher or lower than " + Game.GetNumber() + "?");
      Console.WriteLine("'H' for Higher, 'L' for Lower or 'C' for Correct answer.");
      userInput = Console.ReadLine().ToLower();

      if(userInput == "c")
      {
        Console.WriteLine("Bingo!! ");
      }
      else if(userInput == "h")
      {
        Game.guessForHigher(Game.GetNumber());
        makeGuess();
      }
      else if(userInput == "l")
      {
        Game.guessForLower(Game.GetNumber());
        makeGuess();
      }
      else
      {
        Console.WriteLine("Please enter 'H' for Higher, 'L' for Lower or 'C' for Correct answer.");
        makeGuess();
      }
    }
  }
}