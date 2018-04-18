using NUnit.Framework;

namespace CoinChangerKata
{
    [TestFixture]
    internal class CoinChangerShould
    {
        [TestCase(1, new[]{1}, new[]{1})]
        [TestCase(2, new[]{1}, new[]{2})]
        [TestCase(5, new[]{1}, new[]{5})]
        public void return_coin_change(int input, int[] coinDenomination, int[] expected)
        {
            int[] result = new CoinChanger().GetChange(input, coinDenomination);

            Assert.AreEqual(expected, result);
        }
    }
}
