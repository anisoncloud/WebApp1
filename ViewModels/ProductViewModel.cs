namespace WebApplication1.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public List<int> SelectedCategoryIds { get; set; } = new();
    }
}
