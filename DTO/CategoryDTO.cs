namespace QuickNotes.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }             // auto-généré
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } // optionnel, selon ton modèle
    }
}
