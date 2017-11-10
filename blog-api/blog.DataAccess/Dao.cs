using blog.DataAccess.Entities;
using System;
using System.Linq;

namespace blog.DataAccess
{
    public class Dao : IDao
    {
        private DataContext _context;

        public Dao(DataContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.Where(s => s.Email == email).FirstOrDefault();
        }
    }
}
