using System;
using System.Diagnostics;


namespace AlerterSpace
{
  class AlerterTest
  {
    static void Main(string[] args)
    {
      INetworkAlerter networkAlerter=new NetworkAlerterStub();
      Alerter.CountAlertFailure(400.5f, networkAlerter);
      Debug.Assert(Alerter.alertFailureCount == 0);

      Alerter.CountAlertFailure(303.6f, networkAlerter);
      Debug.Assert(Alerter.alertFailureCount == 1);

      Alerter.CountAlertFailure(100.6f, networkAlerter);
      Debug.Assert(Alerter.alertFailureCount == 2);

      Console.WriteLine("{0} alerts failed.", Alerter.alertFailureCount);
      Console.WriteLine("All is well (maybe!)\n");
      Console.ReadKey();
    }
  }
}
