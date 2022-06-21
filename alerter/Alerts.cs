using System.Diagnostics;

namespace alerter
{
    internal class Alerts
    {
        public int alertFailureCount = 0;

        public void AlertInCelcius(float farenheit)
        {
           StubNetwork stubNetwork = new StubNetwork();
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = stubNetwork.NetworkAlertStub(celcius);
            if (returnCode != 200)
            {
                alertFailureCount += 0;
                Debug.Assert(alertFailureCount > 0);
            }
        }
    }
}
