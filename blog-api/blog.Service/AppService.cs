using AutoMapper;
using blog.Common.DTO;
using blog.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Service
{
    public class AppService : IAppService
    {
        private IDao _dao;
        private IMapper _mapper;

        public AppService(IDao dao, IMapper mapper)
        {
            _dao = dao;
            _mapper = mapper;
        }

        public UserDto Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            var user = _dao.GetUserByEmail(email);

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
