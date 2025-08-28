namespace QuickNotes.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Note> Notes { get; set; } = new List<Note>();



    }
}
