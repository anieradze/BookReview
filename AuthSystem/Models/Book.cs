using Humanizer.Localisation;
namespace BookReview.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public DateTime PublishDate { get; set; } // Add PublishDate property
        public string Genre { get; set; } // Add Genre property
        public string Description { get; set; } // Add Description property
    }
}

