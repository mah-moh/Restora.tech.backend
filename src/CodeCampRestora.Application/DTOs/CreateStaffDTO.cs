using CodeCampRestora.Domain.Entities.Authentication.UserRole;

namespace CodeCampRestora.Application.DTOs;

public class CreateStaffDTO
{
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public UserRoles Role { get; set; }
    public Guid BranchId { get; set; }
}