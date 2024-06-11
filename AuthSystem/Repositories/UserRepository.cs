using BookReview.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookReview.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Update(User user)
        {
            var existingUser = GetById(user.Id);
            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.PhoneNumber = user.PhoneNumber;
                existingUser.Address = user.Address;
            }
        }

        public void Delete(int userId)
        {
            var user = GetById(userId);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public User GetById(int userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public User GetByEmail(string email)
        {
            return _users.FirstOrDefault(u => u.Email == email);
        }
    }
}