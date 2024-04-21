using Microsoft.AspNetCore.Identity;

namespace CodeCampRestora.Domain.Entities.Identity;

public class ApplicationRole : IdentityRole<Guid>
{
    public virtual ICollection<ApplicationUserRole>? UserRoles { get; }
}