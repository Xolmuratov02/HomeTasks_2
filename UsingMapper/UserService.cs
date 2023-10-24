using Mapster;
using UsingMapper.DTOs;
using UsingMapper.Entities;

namespace UsingMapper;

public class UserService
{
    private IList<User> _users = new List<User>();

    public User Create(UserForCreation userForCreation)
    {
        var existUser = _users.FirstOrDefault(u => u.Email.Equals(userForCreation.Email));
        
        if (existUser != null)
        {
            Console.WriteLine("This user already exists");
            return existUser;
        }

        var newUser = userForCreation.Adapt<User>();

        newUser.Id = Guid.NewGuid();
        newUser.CreatedAt = DateTime.UtcNow;
        newUser.UpdatedAt = DateTime.UtcNow;

        _users.Add(newUser);

        return newUser;
    }

    public List<UserViewModel> GetUsers() => _users.Adapt<List<UserViewModel>>();
}