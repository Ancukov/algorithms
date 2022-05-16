using System;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("v");
            stock.PriceChanded
        }

    }
    public class PriceChangedEventArgs : System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            

        }

    }
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    class Stock
    {
        string _synmbol;
        decimal _price;
        public Stock (string synmbol)
        {
            _synmbol = synmbol;
        }
        public event PriceChangedHandler PriceChanded;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value) return;
                decimal oldPrice = _price;
                _price = value;
                if(PriceChanded != null)
                {
                    PriceChanded(oldPrice, _price);
                }
            }
        }
    }
}
