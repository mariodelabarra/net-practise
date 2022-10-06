using HR.LeaveManagment.Application.DTOs;
using MediatR;

namespace HR.LeaveManagment.Application.Features.LeaveRequest.Requests
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
