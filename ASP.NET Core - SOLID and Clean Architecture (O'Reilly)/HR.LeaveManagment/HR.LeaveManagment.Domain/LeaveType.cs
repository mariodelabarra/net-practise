﻿using HR.LeaveManagment.Domain.Common;

namespace HR.LeaveManagment.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
