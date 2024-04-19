using DotnetBlogApi.Dto;

namespace DotnetBlogApi.Service
{
    public interface AuthService
    {
        UserLoginResponse loginUser(UserLoginRequest userLoginRequest);
    }
}
