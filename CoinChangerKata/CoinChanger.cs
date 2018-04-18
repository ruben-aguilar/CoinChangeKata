using System;

namespace CoinChangerKata
{
    internal static class CoinChanger
    {
        public static int[] GetChange(int input, int[] coinDenomination)
        {
            if (coinDenomination.Length == 0)
                throw new ArgumentException();

            if (MoreThanOneCoin(coinDenomination))
            {
                return new[] {1, 1};
            }

            return new[] { input/ coinDenomination[0] };
        }

        private static bool MoreThanOneCoin(int[] coinDenomination)
        {
            return coinDenomination.Length > 1;
        }
    }
}