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
    
    public partial class usp_getTaskTypeWiseProgressByTaskID_Result
    
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
        public Nullable<decimal> PercentWeitage { get; set; }
        public string ProjectMilestone { get; set; }
        public string ProjectMilestoneDesc { get; set; }
        public Nullable<System.DateTime> PlannedStartDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public string ActualEndDate { get; set; }
        public string IsApproved { get; set; }
        public System.DateTime CurrentDate { get; set; }
        public Nullable<int> UploadedFileCount { get; set; }
        public Nullable<int> MileStoneUploadedFileCount { get; set; }
        public Nullable<int> OnTimeDifference { get; set; }
        public string DummyText { get; set; }
        public Nullable<int> Delay { get; set; }
    }
}