namespace WebApplication1.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? CreatedAt {  get; set; }
        public DateTime? UpdatedAt {  get; set; }
    }
}
