using FluentValidation;
using CodeCampRestora.Application.Common;
using CodeCampRestora.Application.Extensions;
using CodeCampRestora.Domain.Entities.Authentication.UserRole;

namespace CodeCampRestora.Application.Features.Staffs.Commands.CreateStaff;

public class CreateStaffCommandValidator : ApplicationValidator<CreateStaffCommand>
{
    public CreateStaffCommandValidator()
    {
        RuleFor(p => p.FullName).NotEmpty().WithMessage("Full name is required");

        RuleFor(p => p.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress();

        RuleFor(p => p.Password).Cascade(CascadeMode.Stop).ValidatePassword();

        RuleFor(p => p.Role)
            .Cascade(CascadeMode.Stop)
            .IsInEnum().WithMessage("Please provide a valid role")
            .Must(p =>
                string.Equals(p.ToString(), UserRoles.Waiter.ToString(), StringComparison.OrdinalIgnoreCase) ||
                string.Equals(p.ToString(), UserRoles.Manager.ToString(), StringComparison.OrdinalIgnoreCase) ||
                string.Equals(p.ToString(), UserRoles.KitchenStuff.ToString(), StringComparison.OrdinalIgnoreCase))
            .WithMessage("Please provide a valid role");

        RuleFor(p => p.BranchId)
            .NotEmpty()
            .WithMessage("Please provide a valid branchId");
    }
}