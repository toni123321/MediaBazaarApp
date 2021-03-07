using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class StockManagement
    {
        private List<Stock> stock;

        public StockManagement()
        {
            this.stock = new List<Stock>();
        }

        public bool AddStock(string model, string brand, double price, int quantity, double height, double width, double depth, string shortDescription)
        {
            return true;
        }

        public bool RemoveStock(int id)
        {
            return true;
        }

        public Stock GetStock(int id)
        {
            return null;
        }
        public List<Stock> GetAllStocks()
        {
            return this.stock;
        }


    }
}
