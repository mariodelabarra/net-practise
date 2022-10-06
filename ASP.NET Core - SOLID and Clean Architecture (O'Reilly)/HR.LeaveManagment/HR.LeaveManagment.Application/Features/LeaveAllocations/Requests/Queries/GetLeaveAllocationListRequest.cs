using HR.LeaveManagment.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
    }
}
