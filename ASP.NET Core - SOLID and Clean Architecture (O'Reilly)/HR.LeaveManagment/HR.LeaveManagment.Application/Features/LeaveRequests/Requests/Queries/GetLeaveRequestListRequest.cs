using HR.LeaveManagment.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace HR.LeaveManagment.Application.Features.LeaveRequest.Requests
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {
    }
}
