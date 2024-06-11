using BookReview.Models;

namespace BookReview.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
        User GetById(int userId);
        User GetByEmail(string email);
    }
}
