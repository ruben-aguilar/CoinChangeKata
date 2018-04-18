using System;
using NUnit.Framework;

namespace CoinChangerKata
{
    [TestFixture]
    internal class CoinChangerShould
    {
        [TestCase(1, new[]{1}, new[]{1})]
        [TestCase(2, new[]{1}, new[]{2})]
        [TestCase(5, new[]{1}, new[]{5})]
        [TestCase(10, new[]{2}, new[]{5})]
        [TestCase(5, new[]{5}, new[]{1})]
        [TestCase(10, new[]{5}, new[]{2})]
        [TestCase(3, new[]{1,2}, new[]{1,1})]
        [TestCase(10, new[]{1,2}, new[]{0,5})]
        [TestCase(11, new[]{1,2}, new[]{1,5})]
        [TestCase(12, new[]{1,2}, new[]{0,6})]
        [TestCase(5, new[]{1,2,5}, new[]{0,0,1})]
        [TestCase(7, new[]{1,2,5}, new[]{0,1,1})]
        [TestCase(8, new[]{1,2,5}, new[]{1,1,1})]
        public void return_coin_change(int input, int[] coinDenomination, int[] expected)
        {
            int[] result = CoinChanger.GetChange(input, coinDenomination);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void throw_an_exception_when_doesnt_have_any_coin()
        {
            Assert.Throws<ArgumentException>(() => CoinChanger.GetChange(1, new int[] { }));
        }

        [Test]
        public void throw_an_exception_when_coin_denomanitation_not_initialized()
        {
            Assert.Throws<ArgumentException>(() => CoinChanger.GetChange(1, null));
        }
    }
}
