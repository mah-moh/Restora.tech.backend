using CodeCampRestora.Application.Attributes;
using CodeCampRestora.Domain.Entities.Identity;
using CodeCampRestora.Infrastructure.Identity.Interfaces;

namespace CodeCampRestora.Infrastructure.Identity.Adapters;

[ScopedLifetime]
public class ApplicationRoleManagerAdapter : IApplicationRoleManagerAdapter
{
    private readonly IApplicationRoleManager _applicationRoleManager;

    public ApplicationRoleManagerAdapter(IApplicationRoleManager applicationRoleManager)
    {
        _applicationRoleManager = applicationRoleManager;
    }

    public async Task<ApplicationRole?> FindByNameAsync(string roleName)
    {
        return await _applicationRoleManager.FindByNameAsync(roleName);
    }
}