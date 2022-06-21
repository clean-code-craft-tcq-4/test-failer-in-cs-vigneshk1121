using System;

namespace alerter
{
    internal class StubNetwork
    {
        public int NetworkAlertStub(float celcius)
        {
            if (celcius > 0)
            {
                Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
                return 200;
            }

            return 500;
        }
    }
}
