using BookReview.Models;

namespace BookReview.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(int bookId);
        IEnumerable<Book> GetByTitle(string title);
        IEnumerable<Book> GetByAuthor(string author);
    }
}
