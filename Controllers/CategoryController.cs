
using global::QuickNotes.DTO;
using Microsoft.AspNetCore.Mvc;

using QuickNotes.Services;
namespace QuickNotes.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // Création d'une catégorie
        [HttpPost]
        public ActionResult<CategoryDTO> Create([FromBody] CategoryCreateDto request)
        {
            var created = _categoryService.Create(request);

            return Ok(created); ;
        }
    }

}
