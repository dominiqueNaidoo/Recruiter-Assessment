using CoinJarBLL.Services;
using Moq;
using NUnit.Framework;
using System;
using Xunit;

namespace CoinJarUnitTest
{
    public class CoinJarTest
    {
        private readonly ICoinJar coinJarService;

        public CoinJarTest(ICoinJar coinJar)
        {
            this.coinJarService = coinJar;
        }
        public Mock<ICoinJar> mock = new Mock<ICoinJar>();

        [Fact]
        public void AddCoin()
        {
            var result = coinJarService.AddCoin(CoinJarBLL.eNums.enumCoinType.Cent, 1);
            Assert.AreEqual(0.01, result);
        }
    }
}
