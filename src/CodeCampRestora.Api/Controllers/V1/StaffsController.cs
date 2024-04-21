using CodeCampRestora.Application.Features.Staffs.Commands.CreateStaff;
using Microsoft.AspNetCore.Mvc;

namespace CodeCampRestora.Api.Controllers.V1;

[Route("/api/v1/staffs")]
public class StaffsController : ApiBaseController
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateStaffCommand command)
    {
        var result = await Sender.Send(command);
        return result.ToActionResult();
    }
}