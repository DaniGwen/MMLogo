namespace MMLogo
{
    using System.Text;

    public class Draw
    {
        // Global variables
        public const char Dash = '-';
        public const char Star = '*';

        public Draw()
        {
        }

        public string TopHalf(int starCount, int dashCount, int middleDashes)
        {
            var sb = new StringBuilder();

            //Left side 'M'
            sb.Append(Dash, dashCount)
                     .Append(Star, starCount)
                     .Append(Dash, middleDashes)
                     .Append(Star, starCount)
                     .Append(Dash, dashCount)
                     // Right side 'M'
                     .Append(Dash, dashCount)
                     .Append(Star, starCount)
                     .Append(Dash, middleDashes)
                     .Append(Star, starCount)
                     .Append(Dash, dashCount)
                     .AppendLine();

            return sb.ToString();
        }

        public string BottomHalf(int starCount, int dashCount, int middleDashes, int middleStars)
        {
            var sb = new StringBuilder();

            // Left side 'M'
            sb.Append(Dash, dashCount)
                     .Append(Star, starCount)
                     .Append(Dash, middleDashes)
                     .Append(Star, middleStars)
                     .Append(Dash, middleDashes)
                     .Append(Star, starCount)
                     .Append(Dash, dashCount)
                     // Right side 'M'
                     .Append(Dash, dashCount)
                     .Append(Star, starCount)
                     .Append(Dash, middleDashes)
                     .Append(Star, middleStars)
                     .Append(Dash, middleDashes)
                     .Append(Star, starCount)
                     .Append(Dash, dashCount)
                     .AppendLine();

            return sb.ToString();
        }

    }
}
