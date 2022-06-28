using misaligned;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MisalignedSpace
{
    class Misaligned
    {


        static List<ColorMap> GetColorMap(string[] majorColors, string[] minorColors)
        {
            List<ColorMap> colorMaps = new List<ColorMap>();
            for (int i = 0; i < majorColors.Length; i++)
            {
                for (int j = 0; j < minorColors.Length; j++)
                {
                    colorMaps.Add(new ColorMap
                    {
                        PairNumber = (i * 5 + j) + 1,
                        MajorColor = majorColors[i],
                        MinorColor = minorColors[j]
                    });
                }
            }

            return colorMaps;
        }

        static void PrintColorMap(List<ColorMap> colorMaps)
        {
            for (int i = 0; i < colorMaps.Count; i++)
            {
                Console.WriteLine("{0} | {1} | {2}", colorMaps[i].PairNumber, colorMaps[i].MajorColor, colorMaps[i].MinorColor);

            }
        }

        static void Main(string[] args)
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

           var colorMap = GetColorMap(majorColors, minorColors);

            PrintColorMap(colorMap);

            ColorMapTest colorMapTest = new ColorMapTest(colorMap);
            colorMapTest.TestColorMap(majorColors, minorColors);

            Console.WriteLine("All is well (maybe!)");
        }
    }

   public class ColorMap
    {
        public int PairNumber { get; set; }

        public string? MajorColor { get; set; }

        public string? MinorColor { get; set; }
    }
}
