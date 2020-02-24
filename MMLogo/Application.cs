using MMLogo.Helpers;
using System;

namespace MMLogo
{
    public static class Application
    {
        public static void Run()
        {
            // Input
            int n = 0;

            try
            {
                Console.Write("Enter odd number: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("Please Enter Odd number.");
                    return;
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
           

            var draw = new Draw();

            double topHalfLength = HelperClass.TopHalfLength(n);
            double bottomHalfLength = HelperClass.BottomHalfLength(n, topHalfLength);
            int dashCount = n;
            int starCount = n;
            int middleDashes = n;
            int middleStars = 0;

            // Draw  First Half
            for (int col = 1; col <= topHalfLength; col++)
            {
                Console.Write(draw.TopHalf(starCount, dashCount, middleDashes));

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
            for (int col = 1; col <= bottomHalfLength; col++)
            {

                Console.Write(draw.BottomHalf(starCount, dashCount, middleDashes, middleStars));

                dashCount -= 1;
                middleStars -= 2;
                middleDashes += 2;

                if (dashCount < 0)
                {
                    break;
                }
            };

            Console.ReadKey();
        }
    }
}
