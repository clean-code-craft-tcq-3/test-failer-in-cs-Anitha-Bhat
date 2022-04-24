using System;
using System.Diagnostics;

namespace AlerterSpace
{
  
  class Alerter
  {
    static int alertFailureCount = 0;

    static void CountAlertFailure(float farenheit)
    {
      INetworkAlerter networkAlerter=new NetworkAlerter();
      float celcius = (farenheit - 32) * 5 / 9;
      int returnCode = networkAlerter.networkAlert(celcius);
      if (returnCode != 200)
      {
        // non-ok response is not an error! Issues happen in life!
        // let us keep a count of failures to report
        // However, this code doesn't count failures!
        // Add a test below to catch this bug. Alter the stub above, if needed.
        alertFailureCount += 0;
      }
    }

    static void Main(string[] args)
    {
      CountAlertFailure(400.5f);
      Debug.Assert(alertFailureCount == 0);

      CountAlertFailure(303.6f);
      Debug.Assert(alertFailureCount == 1);

      CountAlertFailure(100.6f);

      Debug.Assert(alertFailureCount == 2);

      Console.WriteLine("{0} alerts failed.", alertFailureCount);
      Console.WriteLine("All is well (maybe!)\n");
      Console.ReadKey();
    }
  }
}
