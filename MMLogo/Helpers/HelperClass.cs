using System;

namespace MMLogo.Helpers
{
    public static class HelperClass
    {
        public static int CalculateMiddleStars(int starCount, int middleStars,int n)
        {
            starCount = ((starCount - 2) * 2) + 1;
            middleStars = starCount - (2 * n);

            return middleStars;
        }

        public static double TopHalfLength(int n)
        {
            return Math.Ceiling((double)n / 2);
        }

        public static double BottomHalfLength(int n, double topHalfLength)
        {
            return (n + 1) - topHalfLength;
        }
    }
}
