namespace Drag_Drop.Data
{
    public class Order
    {
        public int Id { get; set; }

        public int ProductId { get; set; } //M:1
        public Product Products { get; set; }

        public string ClientId { get; set; }  //M:1
        public Client Clients { get; set; }

        public int Quantity { get; set; }
        public DateTime RegisterOn { get; } = DateTime.Now;
    }
}
