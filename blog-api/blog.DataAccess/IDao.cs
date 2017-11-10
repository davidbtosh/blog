using blog.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.DataAccess
{
    public interface IDao
    {
        User GetUserById(int id);

        User GetUserByEmail(string email);
    }
}
