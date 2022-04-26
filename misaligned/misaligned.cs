using System;
using System.Diagnostics;

namespace MisalignedSpace
{
  class Misaligned
  {
    static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
    static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

    static int printColorMap()
    {

      int i = 0, j = 0;
      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          int pairNumber = GetPairNumber(i, j);

          if (pairNumber < 1 || pairNumber > majorColors.Length * minorColors.Length)
          {
            throw new ArgumentOutOfRangeException(
              string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
          }

          Console.WriteLine("{0} | {1} | {2}", pairNumber, majorColors[i], minorColors[i]);
        }
      }
      return i * j;
    }

    static int GetPairNumber(int x, int y)
    {
      return x * 5 + y;
    }

    static void Main(string[] args)
    {
      int result = printColorMap();
      Debug.Assert(result == 25);
      Console.WriteLine("All is well (maybe!)");
    }
  }
}
