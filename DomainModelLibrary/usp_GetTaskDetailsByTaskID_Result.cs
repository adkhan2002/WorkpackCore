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
    
    public partial class usp_GetTaskDetailsByTaskID_Result
    
    {
        public string TaskOwner { get; set; }
        public int ProjectTaskID { get; set; }
        public int ProjectID { get; set; }
        public string TaskName { get; set; }
        public string IsDeliverable { get; set; }
        public int DepatmentID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public decimal AllottedHours { get; set; }
        public int ProgressSheetLock { get; set; }
        public Nullable<decimal> ConsumedHrs { get; set; }
        public int TaskTypeID { get; set; }
        public Nullable<int> Priority { get; set; }
        public int DesignationID { get; set; }
        public string PrerequisiteInformation { get; set; }
        public string Deliverables { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> TaskOwnerID { get; set; }
        public string TaskStatus { get; set; }
        public Nullable<int> ResourceRequestID { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public string TaskType { get; set; }
        public string PriorityName { get; set; }
        public Nullable<decimal> progress { get; set; }
        public Nullable<decimal> ABC { get; set; }
        public string TaskNo { get; set; }
        public Nullable<System.DateTime> TaskcancelledDate { get; set; }
        public string WBSCode { get; set; }
        public string WBSID { get; set; }
    }
}
