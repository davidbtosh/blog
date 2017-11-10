using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Common.DTO
{
    public class UserDto
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        public bool Following { get; set; }

        public string Token { get; set; }
    }
}
