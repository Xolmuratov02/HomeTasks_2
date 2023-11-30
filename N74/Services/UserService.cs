using N74.Models;

namespace N74.Services;

public class UserService
{
    public ValueTask<User?> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var valid = userId.Equals(Guid.Parse("392B23AA-DA4C-4D9F-AF54-B8FFB5882FF3"));

        var user = valid
            ? new User
            {
                Id = userId
            }
            : null;

        return ValueTask.FromResult(user);
    }
}