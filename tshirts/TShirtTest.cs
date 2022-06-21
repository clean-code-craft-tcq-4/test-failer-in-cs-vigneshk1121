using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tshirts
{
    static class TShirtTest
    {
        static string Size(int cms)
        {
            if (cms < 38)
            {
                return "S";
            }
            if (cms > 38 && cms < 42)
            {
                return "M";
            }

            return "L";
        }

        public static void ThrowErrorIfShirtValueIsNotMatching()
        {
            Debug.Assert(Size(37) == "M");
            Debug.Assert(Size(40) == "L");
            Debug.Assert(Size(43) == "S");
        }
    }
}
