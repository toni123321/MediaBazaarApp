namespace MediaBazaarApp
{
    public class ShelfRestockRequest
    {
        public int ID { get; }
        //static int counterId;
        public Stock Stock { get; }
        public int RequestedQuantity { get; }
        public int SenderID { get; }
        public SRRstatus Status { get; set; }

        public ShelfRestockRequest(int id, Stock stock, int quantity, int senderID, SRRstatus status)
        {
            this.ID = id;
            this.Stock = stock;
            this.RequestedQuantity = quantity;
            this.SenderID = senderID;
            this.Status = status;
        }

        public override string ToString()
        {
            return $"Stock: {this.Stock.Brand} {this.Stock.Model} Quantity: {this.RequestedQuantity} Status: {this.Status}";
        }
    }
}
