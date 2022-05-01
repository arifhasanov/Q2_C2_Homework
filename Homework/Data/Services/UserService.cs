namespace Homework.Data.Services;

public class UserService : IUserService
{
    private UserRepository? _userRepository;
    
    public const string SecretCode = "THIS IS SOME VERY SECRET STRING!!! Im blue da ba dee da ba di da ba dee da ba di da d ba dee da ba di da ba dee";

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public string Authenticate(string user, string password)
    {
        var loginUser = _userRepository?.Get(user, password);
        if (loginUser == null)
        {
            return string.Empty;
        }
        else
        {
            return GenerateJwtToken(loginUser.Id);
        }
    }

    private string GenerateJwtToken(int id)
    {
        JwtSecurityTokenHandler tokenHandler = new
        JwtSecurityTokenHandler();
        byte[] key = Encoding.ASCII.GetBytes(SecretCode);
        SecurityTokenDescriptor tokenDescriptor = new
        SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
        {
            new Claim(ClaimTypes.Name, id.ToString())
        }),
            Expires = DateTime.UtcNow.AddMinutes(15),
            SigningCredentials = new SigningCredentials(new
        SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        SecurityToken token =
        tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
