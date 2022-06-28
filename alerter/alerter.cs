using alerter;
using System;

namespace AlerterSpace
{
    class Alerter
    {
        static void Main(string[] args) {
            IAlerter alerter = new Alerts();
            alerter.AlertInCelcius(10.5f);
            alerter.AlertInCelcius(303.6f);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
