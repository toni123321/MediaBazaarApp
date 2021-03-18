using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class StockManagement
    {
        private List<Stock> stocks;

        public StockManagement()
        {
            this.stocks = new List<Stock>();
        }

        public void AddStock(string model, string brand, double price, int quantity, double height, double width, double depth, double weight, string shortDescription)
        {
            if (SearchForStock(model, brand) != null)
            {
                SearchForStock(model, brand).Quantity += quantity;
            }
            else
            {
                Stock stock = new Stock(model, brand, price, quantity, height, width, depth, weight, shortDescription);
                stocks.Add(stock);
            }

        }

        public Stock SearchForStock(string model, string brand)
        {
            foreach (Stock stock in stocks)
            {
                if (stock.Model == model && stock.Brand == brand)
                {
                    return stock;
                }
            }
            return null;
        }

        public void RemoveStock(Stock stock)
        {
            stocks.Remove(stock);
        }

        public Stock GetStock(int id)
        {
            foreach (Stock stock in stocks)
            {
                if (id == stock.Id)
                {
                    return stock;
                }
            }
            return null;
        }
        public List<Stock> GetAllStocks()
        {
            return this.stocks;
        }


    }
}
