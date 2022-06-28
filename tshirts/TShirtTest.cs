using System.Diagnostics;

namespace tshirts
{
    static class TShirtTest
    {
        static SizeChart Size(int size)
        {
            if (size <= 38)
            {
                return SizeChart.Small;
            }
            if (size > 38 && size < 42)
            {
                return SizeChart.Medium; ;
            }

            return SizeChart.Large;
        }

        public static void ThrowErrorIfShirtValueIsNotMatching()
        {
            Debug.Assert(Size(37) == SizeChart.Small);
            Debug.Assert(Size(40) == SizeChart.Medium);
            Debug.Assert(Size(43) == SizeChart.Large);
            Debug.Assert(Size(42) == SizeChart.Large);
            Debug.Assert(Size(38) == SizeChart.Small);
        }
    }

    public enum SizeChart
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }
}
