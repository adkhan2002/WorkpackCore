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
    
    public partial class TaskMilestoneTargetDates_Contract
    {
        public int TaskMilestoneTargetDatesID { get; set; }
        public int TaskID { get; set; }
        public int TaskTypeID { get; set; }
        public int MileStoneID { get; set; }
        public Nullable<System.DateTime> TaskMilestoneTargetDates { get; set; }
        public Nullable<System.DateTime> ActualTaskMilestoneTargetDates { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyOn { get; set; }
        public string DelayAlertSent { get; set; }
    }
}
