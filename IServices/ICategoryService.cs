using WebApplication1.Dto;

namespace WebApplication1.IServices
{
    public interface ICategoryService
    {
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto dto);
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
    }
}
