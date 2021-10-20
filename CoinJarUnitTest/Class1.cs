using CoinJarBLL.Services;
using NUnit.Framework;

namespace CoinJarUnitTest
{
    [TestFixture]
    public class CoinJarTest
    {

        [Test]
        public void AddCoin()
        {
            var coinJarService = new CoinJar();
            var result = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Cent, 1);
            var amount = coinJarService.GetTotalAmount();
            Assert.AreEqual(0.01, amount);
        }

        [Test]
        public void GetTotalAmount()
        {
            var coinJarService = new CoinJar();
            var result = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Cent, 1);
            var result2 = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Dime, 1);
            var result3 = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Nickel, 1);
            var result4 = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Quarter, 1);
            var result5 = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Dollar, 1);
            var result6 = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Dollar, 12);
            var amount = coinJarService.GetTotalAmount();
            Assert.AreEqual(13.41, amount);
        }


        [Test]
        public void ResetCoinJar()
        {
            var coinJarService = new CoinJar();
            var result = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Cent, 1);
            coinJarService.Reset();
            Assert.AreEqual(0, 0);
        }
    }
}
