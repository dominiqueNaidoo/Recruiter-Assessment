using CoinJarBLL.eNums;
using System;
using System.Linq;

namespace CoinJarBLL.Services
{
    public interface ICoinJar
    {
        decimal AddCoin(enumCoinType coinType, int count);
        decimal GetTotalAmount();
        void Reset();
    }

    public class CoinJar : ICoinJar
    {
        public CoinJar()
        { }
        private readonly Coin[] coins = Enum.GetValues(typeof(enumCoinType)).Cast<enumCoinType>().Select(x => new Coin(x)).ToArray();

        public decimal AddCoin(enumCoinType coinType, int count = 1)
        {
            return coins.First(x => x.CoinType == coinType).Amount += count;
        }

        public decimal GetTotalAmount() => coins.Select(c => (decimal)c.CoinType * (decimal)c.Amount).Sum() / 100m;

        public void Reset()
        {
            foreach (var c in coins)
            {
                c.Amount = 0;
            }
        }
    }
}

