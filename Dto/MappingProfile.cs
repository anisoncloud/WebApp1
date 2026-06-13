using AutoMapper;
using WebApplication1.Models;

namespace WebApplication1.Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //CreateMap<Source, Destination>().ForMember(s=>s.destionation).Mapfrom(o=>o.source)
            CreateMap<Product, ProductDto>();
            CreateMap<CreateCategoryDto, Category>()
                .ForMember(x => x.ProductCategories, o => o.Ignore());
            CreateMap<Category, CategoryDto>()
                .ForMember(x=>x.CreatedAt, o=>o.MapFrom(p=>p.CreatedAt))
                .ForMember(x=>x.UpdatedAt, o=>o.MapFrom(p=>p.UpdatedAt));
        }
    }
}
