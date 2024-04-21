using CodeCampRestora.Domain.Entities.Identity;

namespace CodeCampRestora.Infrastructure.Identity.Interfaces;

public interface IApplicationRoleManager
{
    Task<ApplicationRole?> FindByNameAsync(string roleName);
}