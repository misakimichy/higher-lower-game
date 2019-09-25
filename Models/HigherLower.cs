using System;

namespace HighLowGame.Models
{
  class Game
  {
    private static int _number;
    private static int _min = 1;
    private static int _max = 100;

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

    public static void initialGuess()
    {
      Random randomNum = new Random();
      _number = randomNum.Next(_min, _max);
    }

    public static void highGuess(int lowNum)
    {
      Random randomNum = new Random();
      if (lowNum > _min)
      {
        _min = lowNum;
      }
      _number = randomNum.Next(_min, _max);
    }

    public static void lowGuess(int highNum)
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