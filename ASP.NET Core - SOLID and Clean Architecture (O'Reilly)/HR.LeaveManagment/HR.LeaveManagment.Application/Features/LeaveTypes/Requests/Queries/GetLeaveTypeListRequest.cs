using HR.LeaveManagment.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
