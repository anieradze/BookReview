// BookRepository.cs
using BookReview.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookReview.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Update(Book book)
        {
            var existingBook = GetById(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublishDate = book.PublishDate; // Assuming PublishDate exists in Book class
                existingBook.Genre = book.Genre; // Assuming Genre exists in Book class
                existingBook.Description = book.Description; // Assuming Description exists in Book class
            }
        }

        public void Delete(int bookId)
        {
            var book = GetById(bookId);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            return _books.Where(b => b.Title.ToLower().Contains(title.ToLower()));
        }

        public IEnumerable<Book> GetByAuthor(string author)
        {
            return _books.Where(b => b.Author.ToLower().Contains(author.ToLower()));
        }

        public Book GetById(int bookId)
        {
            return _books.FirstOrDefault(b => b.Id == bookId);
        }
    }
}
