using System;

namespace alerter
{
    public interface IAlerter
    {
        void AlertInCelcius(float farenheit);
   }

    internal class Alerts: IAlerter
    {
        public int AlertFailureCount = 0;

        private float ConvertToCelcius(float farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }

        public void AlertInCelcius(float farenheit)
        {
            float celcius = ConvertToCelcius(farenheit);

            INetwork network = new RealNetwork();

            INetwork stubNetwork = new StubNetwork();

           var result =  stubNetwork.NetworkAlert(celcius);

            if (result != 200)
            {
                AlertFailureCount++;
            }

            stubNetwork.TestStubNetwork(AlertFailureCount);

            Console.WriteLine("{0} alerts failed.", AlertFailureCount);
        }
    }
}
