using N64.Identity.Application.Common.Identity.Services;
using N64.Identity.Domain.Entities;
using N64.Identity.Persistance.Repositories.Interfaces;

namespace N64.Identity.Infrastructure.Common.Identity.Sevices;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public ValueTask<User?> GetByIdAsync(Guid userId)
    {
        return _userRepository.GetByIdAsync(userId);
    }

    public ValueTask<User> UpdateAsync(User user)
    {
        return _userRepository.UpdateAsync(user);
    }
}