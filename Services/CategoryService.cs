using AutoMapper;
using WebApplication1.Dto;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            await _uow.Categories.AddAsync(category);
            await _uow.CommitAsync();
            return _mapper.Map<CategoryDto>(category);

        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await _uow.Categories.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
    }
}
