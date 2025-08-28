using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuickNotes.Model
{
    public class Note
    {
       
            public int Id { get; set; }
            public string Title { get; set; } = default!;
            public string Content { get; set; } = default!;
            public string? Tags { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
            public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

            public int CategoryId { get; set; }
            public Category? Category { get; set; }
        }


    }
