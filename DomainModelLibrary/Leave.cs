//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leave
    {
        public int LeaveID { get; set; }
        public int LeaveTypeID { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public string Remark { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ApprovedBY { get; set; }
        public string IsHalfDay { get; set; }
    
        public virtual LeaveType LeaveType { get; set; }
    }
}
