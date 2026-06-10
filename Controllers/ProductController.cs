using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;
using WebApplication1.IServices;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _categoryService.GetAllCategoriesAsync();
            return View(new CreateProductDto());
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductDto dto)
        {

        }
        
    }
}
