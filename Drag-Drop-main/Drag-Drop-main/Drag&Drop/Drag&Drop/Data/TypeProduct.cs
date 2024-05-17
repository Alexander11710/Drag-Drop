namespace Drag_Drop.Data
{
    public class TypeProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegisterOn { get; set; } = DateTime.Now;

        //1:M
        public ICollection<Product> Products { get; set; }
    }
}
