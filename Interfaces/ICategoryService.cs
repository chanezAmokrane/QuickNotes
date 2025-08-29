using QuickNotes.DTO;

namespace QuickNotes.Services
{
    public interface ICategoryService
    {
        CategoryDTO Create(CategoryCreateDto request);
    }
}