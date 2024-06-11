using AuthSystem.Models;

namespace BookReview.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public int BookId { get; set; }
        public string Content { get; set; } = "";
        public int Rating { get; set; }

        public ApplicationUser User { get; set; } = new ApplicationUser();
        public Book Book { get; set; } = new Book();
    }

}
