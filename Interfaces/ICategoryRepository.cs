using QuickNotes.Model;

namespace QuickNotes.Interfaces
{
    public interface ICategoryRepository
    {
        bool ExistsByName(string name);
        void Add(Category category);
        void SaveChanges();
    }
}
