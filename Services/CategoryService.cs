// CategoryService.cs
using QuickNotes.DTO;
      // ton entity Category
using QuickNotes.Interfaces;
using QuickNotes.Model;
using QuickNotes.Repositories;    // ton ICategoryRepository

namespace QuickNotes.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public CategoryDTO Create(CategoryCreateDto request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ArgumentException("Name is required.", nameof(request.Name));

            // Optionnel : vérifier l’unicité
            if (_repo.ExistsByName(request.Name))
                throw new InvalidOperationException("Category name already exists.");

            var entity = new Category
            {
                Name = request.Name.Trim(),
                Description = string.IsNullOrWhiteSpace(request.Description) ? null : request.Description.Trim()
            };

            _repo.Add(entity);          // persiste (implémentation repo à faire ensuite)
            _repo.SaveChanges();        // ou UnitOfWork si tu utilises

            return new CategoryDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
                // Ajoute CreatedAt si tu l’as dans l’entity
            };
        }
    }
}
