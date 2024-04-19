using DotnetBlogApi.Data;
using DotnetBlogApi.Dto;
using DotnetBlogApi.Models;

namespace DotnetBlogApi.Repository.Impl
{
    public class UserRepositoryImpl : UserRepository
    {
        private readonly DataContext _context;

        public UserRepositoryImpl(DataContext dataContext)
        {
            _context = dataContext;
        }

        public bool CreateUser(UserDTO userDTO)
        {
            User user = new User();
            if(userDTO.Username != null && userDTO.Password != null)
            {

            }
            return true;
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool existsUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public User getUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
