using System.Collections.Generic;
using System.Linq;

namespace MediaBazaarApp
{
    public class StatisticsStock
    {

        public List<Stock> GetLowestPrice(List<Stock> stocks)
        {
            List<Stock> LowestPriceList = stocks.OrderBy(o => o.Price).ToList();
            return LowestPriceList;
        }

        public List<Stock> GetHighestPrice(List<Stock> stocks)
        {
            List<Stock> HighestPriceList = stocks.OrderBy(o => o.Price).ToList();
            HighestPriceList.Reverse();
            return HighestPriceList;
        }
        public List<Stock> GetSmallestQuantity(List<Stock> stocks)
        {
            List<Stock> SmallestQuantityFirst = stocks.OrderBy(o => o.Quantity).ToList();
            return SmallestQuantityFirst;
        }
        public List<Stock> GetBiggestQuantity(List<Stock> stocks)
        {
            List<Stock> BiggestQuantityFirst = stocks.OrderBy(o => o.Quantity).ToList();
            BiggestQuantityFirst.Reverse();
            return BiggestQuantityFirst;
        }
    }
}
