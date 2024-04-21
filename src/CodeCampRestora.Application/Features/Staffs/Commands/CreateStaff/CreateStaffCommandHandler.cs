using Mapster;
using CodeCampRestora.Domain.Entities;
using CodeCampRestora.Application.DTOs;
using CodeCampRestora.Application.Models;
using CodeCampRestora.Application.Common.Interfaces.Services;
using CodeCampRestora.Application.Common.Interfaces.MediatRs;
using CodeCampRestora.Domain.Entities.Authentication.UserRole;

namespace CodeCampRestora.Application.Features.Staffs.Commands.CreateStaff;

public record CreateStaffCommand(
    string FullName,
    string Email,
    string Password,
    UserRoles Role,
    Guid BranchId) : ICommand<IResult>;

public class CreateStaffCommandHandler : ICommandHandler<CreateStaffCommand, IResult>
{
    private readonly IIdentityService _identityService;

    public CreateStaffCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<IResult> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
    {
        var createStaffDto = request.Adapt<CreateStaffDTO>();
        // var staff = new Staff
        // {
        //     UserName = Guid.NewGuid().ToString(),
        //     Email = request.Email,
        //     FullName = request.FullName,
        //     BranchId = request.BranchId
        // };

        return await _identityService.CreateStaff(createStaffDto);
    }
}