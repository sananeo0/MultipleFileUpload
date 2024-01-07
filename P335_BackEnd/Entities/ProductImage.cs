namespace P335_BackEnd.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public Product Product { get; set; }
    }
}
