using WebApplication1.Dto;

namespace WebApplication1.IServices
{
    public interface IProductService
    {
        Task<ProductDto> CreateProductAsync(CreateProductDto dto);
        Task<IEnumerable<ProductDto>> GetAllProductAsync();
    }
}
