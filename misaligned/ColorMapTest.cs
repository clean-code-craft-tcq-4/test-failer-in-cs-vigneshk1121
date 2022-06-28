using MisalignedSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misaligned
{
    public class ColorMapTest
    {
       List<ColorMap> ColorMap;

       public ColorMapTest(List<ColorMap> colorMaps)
        {
            ColorMap = colorMaps;
        }

        public void TestColorMap(string[] majorColors, string[] minorColors)
        {
            for (int i = 0; i < ColorMap.Count; i++)
            {
                Debug.Assert(ColorMap[i] != null);
                Debug.Assert(ColorMap[i].PairNumber == i+1);
            }

            Debug.Assert(GetTotalCount(majorColors, minorColors) == 25);
        }

        static int GetTotalCount(string[] majorColors, string[] minorColors)
        {
            return majorColors.Length * minorColors.Length;
        }
    }
}
