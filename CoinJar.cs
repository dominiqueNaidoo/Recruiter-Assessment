using System;

public interface ICoinJar
{
	void AddCoin(ICoin coin);
	decimal GetTotalAmount();
	void Reset();
}
public class CoinJar : ICoinJar
{
	public CoinJar()
	{
        public void AddCoin(ICoin coin)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalAmount()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
