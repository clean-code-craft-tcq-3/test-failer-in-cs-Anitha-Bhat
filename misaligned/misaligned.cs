using System;
using System.Collections.Generic;

namespace MisalignedSpace
{
  public class Misaligned
  {
    static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
    static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

    public static List<ColorCodeInfo> printColorMap()
    {
      List<ColorCodeInfo> colorCodeList = new List<ColorCodeInfo>();

      int i,j;
      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          int pairNumber = GetPairNumber(i, j);
          string colorFormatToDisplay =
            String.Format("{0,-10} | {1,-10} | {2,-10}", pairNumber, majorColors[i], minorColors[j]);
          colorCodeList.Add(
            new ColorCodeInfo
            {
              majorColor = majorColors[i],
              minorColor = minorColors[i],
              printFormat = colorFormatToDisplay

            });

          Console.WriteLine(colorFormatToDisplay);
        }
      }
      return colorCodeList;
    }

    static int GetPairNumber(int x, int y)
    {
      return x * 5 + y+1;
    }

  }
}
