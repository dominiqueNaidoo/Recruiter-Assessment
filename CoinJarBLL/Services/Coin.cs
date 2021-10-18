using CoinJarBLL.eNums;
using System;

namespace CoinJarBLL.Services
{
    public class Coin
    {
        public readonly enumCoinType CoinType;

        public Coin(enumCoinType coinType)
        {
            CoinType = coinType;
        }
        public decimal Amount { get; set; } = 0;
    }
}

