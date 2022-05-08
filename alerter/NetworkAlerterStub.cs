using System;

namespace AlerterSpace
{
 public class NetworkAlerterStub : INetworkAlerter
  {
    private static int NETWORK_ALERTSUCCESS = 200;
    private static int NETWORK_ALERTFAILURE = 500;
    private static int THRESHOLD_TEMPERATURE = 200;

    public  int networkAlert(float celcius)
    {
      Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
      if (celcius < THRESHOLD_TEMPERATURE)
      {
        return NETWORK_ALERTFAILURE;
      }

      return NETWORK_ALERTSUCCESS;
    }
  }
}
