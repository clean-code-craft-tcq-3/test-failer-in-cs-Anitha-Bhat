using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MisalignedSpace
{
  public class MisalignedTest
  {
    static void Main(string[] args)
    {
      List<ColorCodeInfo> result =Misaligned.printColorMap();
      Debug.Assert(result.Count == 25);
      Debug.Assert(result[0].printFormat.Length == result[result.Count - 1].printFormat.Length);
      Debug.Assert(result[0].majorColor == "White");
      Debug.Assert(result[0].minorColor == "Blue");
      Debug.Assert(result[24].majorColor == "Violet");
      Debug.Assert(result[24].minorColor == "Slate");
      Console.WriteLine("All is well (maybe!)");
     
    }
  }
}
