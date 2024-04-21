﻿using Microsoft.AspNetCore.Identity;
using CodeCampRestora.Domain.Entities.Identity;

namespace CodeCampRestora.Domain.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public string FullName { get; set; } = default!;
    public Guid? RestaurantId { get; set; } = default!;
    public virtual ICollection<ApplicationUserRole>? UserRoles { get; }
}