using System;

namespace DEVTask6
{
    /// <summary>
    /// Class which contain name, amount and price of commodity
    /// </summary>
    public class Commodity
    {
        string name;
        int amount;
        float price;

        public int Amount
        {
            get
            {
                return amount;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
        }

        public Commodity(string paramNames, int paramAmount, float paramPrice)
        {
            if (paramNames.Length == 0)
            {
                throw new System.FormatException();
            }
            name = paramNames;
            if (paramPrice < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            price = paramPrice;
            if(paramAmount<0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            amount = paramAmount;
        }
    }
}
