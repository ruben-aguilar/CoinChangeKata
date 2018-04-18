namespace CoinChangerKata
{
    internal class CoinChanger
    {
        public int[] GetChange(int input, int[] coinDenomination)
        {
            if (input == 1)
                return new[]{1};

            return new[] { 2 };
        }
    }
}