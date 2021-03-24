using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class SalesManagement
    {
        private List<ShelfRestockRequest> requests;

        public SalesManagement()
        {
            requests = new List<ShelfRestockRequest>();
        }

        public void AddRequest(Stock stock, int quantity, int senderID, SRRstatus status)
        {
            ShelfRestockRequest srr = new ShelfRestockRequest(stock, quantity, senderID, status);
            requests.Add(srr);
        }

        public bool RemoveRequest(ShelfRestockRequest srr)
        {
            if (requests.Contains(srr))
            {
                requests.Remove(srr);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ShelfRestockRequest> GetAllSRRRequests()
        {
            return this.requests;
        }

        public ShelfRestockRequest GetSRR(int id)
        {
            foreach (ShelfRestockRequest srr in requests)
            {
                if (srr.ID == id)
                {
                    return srr;
                }
            }
            return null;
        }
    }
}
