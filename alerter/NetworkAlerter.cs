
using System;

namespace AlerterSpace
{
 public class NetworkAlerter : INetworkAlerter
  {
    private static int NETWORK_ALERTSUCCESS = 200;

    public  int networkAlert(float celcius)
    {
      Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
      // calculation for networkalert.we assume it always returns true
      return NETWORK_ALERTSUCCESS;
    }
  }
}
