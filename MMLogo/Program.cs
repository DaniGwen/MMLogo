using System;
using System.Text;

namespace MMLogo
{
    class Program
    {
        // Global variable
        public const char dash = '-';
        public const char star = '*';
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter odd number: ");
            int n = int.Parse(Console.ReadLine());

            double topHalf = Math.Ceiling((double)n / 2);
            double bottomHalf = (n + 1) - topHalf;
            int dashCount = n;
            int starCount = n;
            int middleDashes = n;
            int middleStars = 0;

            // Draw  First Half
            for (int col = 1; col <= topHalf; col++)
            {
                Console.Write(TopHalf(starCount, dashCount, middleDashes));
                starCount += 2;
                dashCount -= 1;
                middleDashes -= 2;
            }

            // Calculate middle stars for the bottom half
            starCount = ((starCount - 2) * 2) + 1;
            middleStars = starCount - (2 * n);

            //reset Middle dashes
            middleDashes = 1;

            // Reset star count for left and right stars
            starCount = n;

            // Draw bottom half
            for (int col = 1; col <= bottomHalf; col++)
            {
                Console.Write(BottomHalf(starCount, dashCount, middleDashes, middleStars));
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

        private static string TopHalf(int starCount,
            int dashCount,
            int middleDashes)
        {
            var sb = new StringBuilder();

            //Left side 'M'
            sb.Append(dash, dashCount)
                     .Append(star, starCount)
                     .Append(dash, middleDashes)
                     .Append(star, starCount)
                     .Append(dash, dashCount)
                     // Right side 'M'
                     .Append(dash, dashCount)
                     .Append(star, starCount)
                     .Append(dash, middleDashes)
                     .Append(star, starCount)
                     .Append(dash, dashCount)
                     .AppendLine();

            return sb.ToString();
        }

        private static string BottomHalf(int starCount,
            int dashCount,
            int middleDashes,
            int middleStars)
        {
            var sb = new StringBuilder();

            // Left side 'M'
            sb.Append(new string(dash, dashCount))
                     .Append(star, starCount)
                     .Append(dash, middleDashes)
                     .Append(star, middleStars)
                     .Append(dash, middleDashes)
                     .Append(star, starCount)
                     .Append(dash, dashCount)
                     // Right side 'M'
                     .Append(dash, dashCount)
                     .Append(star, starCount)
                     .Append(dash, middleDashes)
                     .Append(star, middleStars)
                     .Append(dash, middleDashes)
                     .Append(star, starCount)
                     .Append(dash, dashCount)
                     .AppendLine();

            return sb.ToString();
        }

    }
}
