using Azure;
using Azure.Core;
using DotnetBlogApi.Dto;
using DotnetBlogApi.Repository;

namespace DotnetBlogApi.Service.Impl
{
    public class AuthServiceImpl : AuthService
    {
        private readonly UserRepository _userRepository;
        private readonly TokenService _tokenService;
        public AuthServiceImpl(UserRepository userRepository, TokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }
        public async UserLoginResponse loginUser(UserLoginRequest userLoginRequest)
        {
            UserLoginResponse response = new();
            if (string.IsNullOrEmpty(userLoginRequest.Username) || string.IsNullOrEmpty(userLoginRequest.Password))
            {
                throw new ArgumentNullException(nameof(userLoginRequest));
            }
            if(_userRepository.existsUser(userLoginRequest) == false)
            {
                var generatedTokenInformation = await _tokenService.GenerateToken(new UserLoginRequest { Username = userLoginRequest.Username });

                response.Token = generatedTokenInformation.Token;
            }
            return response;
        }
    }
}
