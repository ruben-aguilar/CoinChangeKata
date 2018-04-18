using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinChangerKata
{
    internal static class CoinChanger
    {
        public static int[] GetChange(int input, int[] coinDenomination)
        {
            if (NotValidInput(coinDenomination))
                throw new ArgumentException();

            var change = new List<int>();
            int module = input;

            foreach (int coinType in coinDenomination.Reverse())
            {
                int result = module / coinType;
                module = module % coinType;

                change.Insert(0, result);
            }

            return change.ToArray();
        }

        private static bool NotValidInput(int[] coinDenomination)
        {
            return coinDenomination == null || coinDenomination.Length == 0;
        }
    }
}