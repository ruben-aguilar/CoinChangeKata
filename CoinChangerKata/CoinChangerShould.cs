using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoinChangerKata
{
    [TestFixture]
    internal class CoinChangerShould
    {
        [Test]
        public void return_coin_change()
        {
            var coinDenomination = new[] {1};

            int[] result = new CoinChanger().GetChange(1, coinDenomination);

            Assert.AreEqual(new int[]{1}, result);
        }
    }
}
