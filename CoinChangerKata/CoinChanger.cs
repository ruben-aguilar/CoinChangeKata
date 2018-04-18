namespace CoinChangerKata
{
    internal static class CoinChanger
    {
        public static int[] GetChange(int input, int[] coinDenomination)
        {
            return new[] { input/ coinDenomination[0] };
        }
    }
}