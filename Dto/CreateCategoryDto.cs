using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dto
{
    public class CreateCategoryDto
    {
        [Required(ErrorMessage = "Product Name is required")]
        [MaxLength(200, ErrorMessage = "Name Can not be exceed 200 character")]
        public string Name { get; set; } = default!;
        [MaxLength(2000)]
        public string? Description { get; set; }
    }
}
