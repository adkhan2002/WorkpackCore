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
    
    public partial class TimeSheetWeeklyDetail
    {
        public int TimeSheetID { get; set; }
        public int TaskID { get; set; }
        public System.DateTime TimesheetDate { get; set; }
        public decimal NorHrs { get; set; }
        public int TimeSheetWeeklyID { get; set; }
        public decimal OTHrs { get; set; }
        public Nullable<decimal> LeaveHrs { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<bool> IsNewActivity { get; set; }
    
        public virtual TimeSheetWeekly TimeSheetWeekly { get; set; }
        public virtual ProjectTaskList ProjectTaskList { get; set; }
    }
}
