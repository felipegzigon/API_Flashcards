namespace Flashcards_API.Models
{
    public class Deck
    {
        public int Id { get; set; } 

        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<Card> Cards { get; set; } = new();
    }
}
