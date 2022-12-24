using BasicAuthService.IService;

namespace BasicAuthService.USERService
{
    public class UserService : IUserService
    {
        public bool CheckUser(string username, string password)
        {
            return username.Equals("Jeremy") && password.Equals("1234");
        }
    }
}
