namespace Homework.Data.Services;

public interface IUserService
{
    string Authenticate(string user, string password);
}
