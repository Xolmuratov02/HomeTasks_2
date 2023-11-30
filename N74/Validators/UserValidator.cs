using FluentValidation;
using N74.Models;
using N74.Services;

namespace N74.Validators;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator(UserService userService)
    {
        RuleSet("OnCreate",
            () =>
            {
                RuleFor(user => user.FirstName).NotEmpty().MinimumLength(3).MaximumLength(10);
                RuleFor(user => user.LastName).NotEmpty().MinimumLength(3).MaximumLength(10);
            });

        RuleSet("OnUpdate",
            () =>
            {
                RuleFor(user => user.Id)
                    .NotEqual(Guid.Empty)
                    .CustomAsync(async (userId, context, cancellationToken) =>
                    {
                        var foundUser = await userService.GetByUserIdAsync(userId, cancellationToken);

                        if (foundUser is null)
                            context.AddFailure(nameof(User.Id), "User with this Id not found");
                    });
                RuleFor(user => user.FirstName).NotEmpty().MinimumLength(3).MaximumLength(10);
                RuleFor(user => user.LastName).NotEmpty().MinimumLength(3).MaximumLength(10);
            });
    }
}