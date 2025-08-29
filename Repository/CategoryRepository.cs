using QuickNotes.Interfaces;
using Microsoft.EntityFrameworkCore;
using QuickNotes.Model;
using QuickNotes.Data;

namespace QuickNotes.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NotesDbContext _context;

        public CategoryRepository(NotesDbContext context)
        {
            _context = context;
        }

        public bool ExistsByName(string name)
        {
            return _context.Categories.Any(c => c.Name == name);
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
