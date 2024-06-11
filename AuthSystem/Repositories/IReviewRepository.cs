using BookReview.Models;

namespace BookReview.Repositories
{
    public interface IReviewRepository
    {
        void Add(Review review);
        void Update(Review review);
        void Delete(int reviewId);
        IEnumerable<Review> GetByBookId(int bookId);
        IEnumerable<Review> GetByUserId(string userId);
    }
}
