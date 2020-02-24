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
    }
}
