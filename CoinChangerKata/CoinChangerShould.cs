using NUnit.Framework;

namespace CoinChangerKata
{
    [TestFixture]
    internal class CoinChangerShould
    {
        private int[] _coinDenomination;

        [Test]
        public void return_coin_change()
        {
            _coinDenomination = new[] {1};

            int[] result = new CoinChanger().GetChange(1, _coinDenomination);

            Assert.AreEqual(new[]{1}, result);
        }

        [Test]
        public void return_two_one_cent_coins_for_two_cents_change_with_only_one_cent_coins()
        {
            _coinDenomination = new[] { 1 };

            int[] result = new CoinChanger().GetChange(2, _coinDenomination);

            Assert.AreEqual(new[] { 2 }, result);
        }
    }
}
