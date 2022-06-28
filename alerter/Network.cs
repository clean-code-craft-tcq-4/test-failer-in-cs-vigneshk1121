using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alerter
{
    public interface INetwork
    {
        int NetworkAlert(float celcius);

        void TestStubNetwork(int returnCode);
    }

    public class RealNetwork : INetwork
    {
        public int NetworkAlert(float celcius)
        {
            // Actual Logic will be placed here (production code)
            return 0;
        }

        public void TestStubNetwork(int returnCode)
        {
            throw new Exception("Production Code - Method should not be executed");
        }
    }

    public class StubNetwork : INetwork
    {
        public int NetworkAlert(float celcius)
        {
            if (celcius > 0)
            {
                Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
                return 200;
            }

            return 500;
        }

        public void TestStubNetwork(int failiureCount)
        {
            Debug.Assert(failiureCount > 0);
        }
    }
}
