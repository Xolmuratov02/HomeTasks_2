using N64.Identity.Domain.Entities;
using N64.Identity.Persistance.DataContexts;
using N64.Identity.Persistance.Repositories.Interfaces;
using System.Linq.Expressions;

namespace N64.Identity.Persistance.Repositories;

public class RoleRepository : EntityRepositoryBase<Role, IdentityDbContext>, IRoleRepository
{
    public RoleRepository(IdentityDbContext dbContext) : base(dbContext)
    {
    }

    public new IQueryable<Role> Get(Expression<Func<Role, bool>>? predicate = default, bool asNoTracking = false)
    {
        return base.Get(predicate, asNoTracking);
    }
}