namespace WebApplication1.Models
{
    public class ProductCategory : BaseEntity
    {
        public int ProductId {  get; set; }
        public Product Product { get; set; } = default!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
