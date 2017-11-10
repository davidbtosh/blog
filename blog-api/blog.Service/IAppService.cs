using blog.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Service
{
    public interface IAppService
    {
        UserDto Authenticate(string email, string password);
    }
}
