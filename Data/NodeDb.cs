using Microsoft.EntityFrameworkCore;
using QuickNotes.Model;


namespace QuickNotes.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options)
        {
        }

        // Tables représentées par EF Core
        public DbSet<Note> Notes { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuration de la table Categories
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Name)
                      .IsRequired()
                      .HasMaxLength(100);
            });

            // Configuration de la table Notes
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Title)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(n => n.Content)
                      .IsRequired();
                entity.Property(n => n.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(n => n.UpdatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");

                // Définition de la relation : une Note appartient à une Category
                entity.HasOne(n => n.Category)
                      .WithMany(c => c.Notes)
                      .HasForeignKey(n => n.CategoryId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
