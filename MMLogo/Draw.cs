namespace MMLogo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Draw
    {
        // Global variables
        public const char Dash = '-';
        public const char Star = '*';

        private readonly int starCount;
        private readonly int dashCount;
        private readonly int middleDashes;
        private readonly int middleStars;

        public Draw(int starCount,
            int dashCount,
            int middleDashes,
            int middleStars)
        {
            this.starCount = starCount;
            this.dashCount = dashCount;
            this.middleDashes = middleDashes;
            this.middleStars = middleStars;
        }

        public string TopHalf()
        {
            var sb = new StringBuilder();

            //Left side 'M'
            sb.Append(Dash, this.dashCount)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.middleDashes)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.dashCount)
                     // Right side 'M'
                     .Append(Dash, this.dashCount)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.middleDashes)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.dashCount)
                     .AppendLine();

            return sb.ToString();
        }

        public string BottomHalf()
        {
            var sb = new StringBuilder();

            // Left side 'M'
            sb.Append(Dash, this.dashCount)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.middleDashes)
                     .Append(Star, this.middleStars)
                     .Append(Dash, this.middleDashes)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.dashCount)
                     // Right side 'M'
                     .Append(Dash, this.dashCount)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.middleDashes)
                     .Append(Star, this.middleStars)
                     .Append(Dash, this.middleDashes)
                     .Append(Star, this.starCount)
                     .Append(Dash, this.dashCount)
                     .AppendLine();

            return sb.ToString();
        }

    }
}
