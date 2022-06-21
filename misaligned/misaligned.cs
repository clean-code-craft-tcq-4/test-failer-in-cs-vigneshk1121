using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static int GetTotalCount(string[] majorColors, string[] minorColors)
        {
            return majorColors.Length * minorColors.Length;
        }

        static void PrintColorMap(string[] majorColors, string[] minorColors)
        {
            for (int i = 0; i < majorColors.Length; i++)
            {
                for (int j = 0; j < minorColors.Length; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }
        }

        static void Main(string[] args) {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

            PrintColorMap(majorColors, minorColors);

            Debug.Assert(GetTotalCount(majorColors, minorColors) != 25);

            Console.WriteLine("All is well (maybe!)");
        }


    }
}
