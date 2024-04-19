using DotnetBlogApi.Dto;
using DotnetBlogApi.Models;

namespace DotnetBlogApi.Repository
{
    public interface UserRepository
    {
        bool CreateUser(UserDTO userDTO);
        bool DeleteUser(int id);
        User getUser(int id);

        bool existsUser(UserLoginRequest userLoginRequest);
    }
}
