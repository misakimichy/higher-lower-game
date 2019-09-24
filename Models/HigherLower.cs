using System;

namespace HighLowGame.Models
{
  class HigherLower
  {
    private static int _number;
    private static int _min = 1;
    private static int _max = 100;

    public static int GetNumber()
    {
      return _input;
    }

    public static void RandomNumber()
    {
      Random randomNum = new Random();
      _number = randomNum.Next(_min, _max);
    }

    public static void higher(int randomNum)
    {
      Random randomNum = new Random();
      if(randomNum > _min)
      {
        _min = randomNum + 1;
      }
      _number = randomNum.Next(_min, _max);
    }

    public static void lower(int randomNum)
    {
      Random randomNum = new Random();
      if(randomNum < _max)
      {
        _max = randomNum -1;
      }
      -_number = randomNum.Next(_min, _max);
    }
  }
}