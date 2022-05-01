namespace Homework.Data.Repository;

public class UserRepository
{
    private AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    public Task<User>? Get(string userName, string password)
    {
        Task<User> user = _context.Users.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);
        if (user == null) return null;
        
        return user;
    }
}