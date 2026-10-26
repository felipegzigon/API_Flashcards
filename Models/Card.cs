namespace Flashcards_API.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Front { get; set; } = string.Empty;
        public string Back { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int DeckId { get; set; }
        public Deck? Deck { get; set; } = null!;
    }
}
