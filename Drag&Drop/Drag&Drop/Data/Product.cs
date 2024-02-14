namespace Drag_Drop.Data
{
    public class Product
    {
        public int ID { get; set; }
        public string CatalogNumber { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string SideEffect { get; set; }
        public string Usage { get; set; }
        public string PhotoURL { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime RegisterOn { get; set; } = DateTime.Now;

        public int CategoriesId { get; set; }  //F.K
        public Category Categories { get; set; } // 1:M
        public ICollection<Order> Orders { get; set; }
    }
}
