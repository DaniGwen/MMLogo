using MMLogo.Helpers;
using System;

namespace MMLogo
{
    public static class Application
    {
        public static void Run()
        {
            // Input
            Console.Write("Enter odd number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double topHalf = Math.Ceiling((double)n / 2);
            double bottomHalf = (n + 1) - topHalf;
            int dashCount = n;
            int starCount = n;
            int middleDashes = n;
            int middleStars = 0;

            // Draw  First Half
            for (int col = 1; col <= topHalf; col++)
            {
                Console.Write(new Draw(starCount, dashCount, middleDashes, middleStars).TopHalf());

                starCount += 2;
                dashCount -= 1;
                middleDashes -= 2;
            }

            // Calculate middle stars for the bottom half
           middleStars = HelperClass.CalculateMiddleStars(starCount, middleStars, n);

            //reset Middle dashes
            middleDashes = 1;

            // Reset star count for left and right stars
            starCount = n;

            // Draw bottom half
            for (int col = 1; col <= bottomHalf; col++)
            {
                Console.Write(new Draw(starCount, dashCount, middleDashes, middleStars).BottomHalf());

                dashCount -= 1;
                middleStars -= 2;
                middleDashes += 2;

                if (dashCount < 0)
                {
                    break;
                }
            };

            Console.WriteLine();
        }
    }
}
