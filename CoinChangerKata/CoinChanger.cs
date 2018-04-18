using System;

namespace CoinChangerKata
{
    internal static class CoinChanger
    {
        public static int[] GetChange(int input, int[] coinDenomination)
        {
            if (NotValidInput(coinDenomination))
                throw new ArgumentException();

            if (MoreThanTwoCoins(coinDenomination))
            {
                var result2 = input / coinDenomination[2];
                var temp2 = input % coinDenomination[2];

                var result1 = temp2 / coinDenomination[1];
                var temp1 = temp2 % coinDenomination[1];

                var result0 = temp1 / coinDenomination[0];

                return new[] { result0, result1, result2 };
            }

            if (TwoCoins(coinDenomination))
            {
                var result1 = input / coinDenomination[1];
                var temp = input % coinDenomination[1];

                var result0 = temp / coinDenomination[0];

                return new[]{ result0, result1 };
            }

            return new[] { input/ coinDenomination[0] };
        }

        private static bool MoreThanTwoCoins(int[] coinDenomination)
        {
            return coinDenomination.Length > 2;
        }

        private static bool NotValidInput(int[] coinDenomination)
        {
            return coinDenomination == null || coinDenomination.Length == 0;
        }

        private static bool TwoCoins(int[] coinDenomination)
        {
            return coinDenomination.Length == 2;
        }
    }
}