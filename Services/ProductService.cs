using AutoMapper;
using WebApplication1.Dto;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ProductDto> CreateProductAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
            };
            foreach (var catId in dto.CategoryIds.Distinct())
            {
                product.ProductCategories
                    .Add(new ProductCategory
                    {
                        CategoryId = catId,
                    });
            }
            await _uow.Products.AddAsync(product);
            await _uow.CommitAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductAsync()
        {
            var products =  await _uow.Products.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
    }
}
