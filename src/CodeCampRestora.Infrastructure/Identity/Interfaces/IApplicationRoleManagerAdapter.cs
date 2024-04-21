using CodeCampRestora.Domain.Entities.Identity;

namespace CodeCampRestora.Infrastructure.Identity.Interfaces;

public interface IApplicationRoleManagerAdapter
{
    Task<ApplicationRole?> FindByNameAsync(string roleName);
}