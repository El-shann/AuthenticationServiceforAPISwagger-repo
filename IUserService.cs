namespace BasicAuthService.IService
{
    public interface IUserService
    {
        bool CheckUser(string username, string password);
    }
}
