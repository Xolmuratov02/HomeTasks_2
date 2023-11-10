using N64.Identity.Domain.Entities;
using System.Linq.Expressions;

namespace N64.Identity.Persistance.Repositories.Interfaces;

public interface IRoleRepository
{
    IQueryable<Role> Get(Expression<Func<Role, bool>>? predicate = default, bool asNoTracking = false);
}