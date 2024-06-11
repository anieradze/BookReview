using BookReview.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookReview.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly List<Review> _reviews = new List<Review>();

        public void Add(Review review)
        {
            _reviews.Add(review);
        }

        public void Update(Review review)
        {
            var existingReview = GetById(review.Id);
            if (existingReview != null)
            {
                existingReview.Content = review.Content;
                existingReview.Rating = review.Rating;
            }
        }

        public void Delete(int reviewId)
        {
            var review = GetById(reviewId);
            if (review != null)
            {
                _reviews.Remove(review);
            }
        }

        public IEnumerable<Review> GetByBookId(int bookId)
        {
            return _reviews.Where(r => r.BookId == bookId);
        }

        public IEnumerable<Review> GetByUserId(string userId)
        {
            return _reviews.Where(r => r.UserId == userId);
        }

        public Review GetById(int reviewId)
        {
            return _reviews.FirstOrDefault(r => r.Id == reviewId);
        }
    }
}
