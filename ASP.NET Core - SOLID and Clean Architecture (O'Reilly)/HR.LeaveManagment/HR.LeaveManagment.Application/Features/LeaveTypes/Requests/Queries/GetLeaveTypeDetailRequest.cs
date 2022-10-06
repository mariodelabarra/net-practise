using HR.LeaveManagment.Application.DTOs;
using MediatR;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
