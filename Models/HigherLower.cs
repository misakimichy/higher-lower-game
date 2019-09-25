using System;

namespace HighLowGame.Models
{
  class Game
  {
    private static int _number;
    private static int _min = 1;
    private static int _max = 101;

    public static int GetNumber()
    {
      return _number;
    }

    public static int GetMin()
    {
      return _min;
    }

    public static int GetMax()
    {
      return _max;
    }

    // Random class ref: https://docs.microsoft.com/en-us/dotnet/api/system.random?redirectedfrom=MSDN&view=netframework-4.8
    public static void initialGuess()
    {
      Random randomNum = new Random();
      _number = randomNum.Next(_min, _max);
    }

    public static void guessForHigher(int lowNum)
    {
      Random randomNum = new Random();
      if (lowNum > _min)
      {
        _min = lowNum;
      }
      _number = randomNum.Next(_min, _max);
    }

    public static void guessForLower(int highNum)
    {
      Random randomNum = new Random();
      if(highNum < _max)
      {
        _max = highNum;
      }
      _number = randomNum.Next(_min, _max);
    }
  }
}