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
    
    public partial class usp_getDrillDownProjectByProjectId_Result
    
    {
        public int id { get; set; }
        public string TaskName { get; set; }
        public string StartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string EndDate { get; set; }
        public string ActualEndDate { get; set; }
        public decimal AllottedHours { get; set; }
        public int TaskTypeID { get; set; }
        public Nullable<int> Priority { get; set; }
        public string Remarks { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public string TaskType { get; set; }
        public string TaskTypeCode { get; set; }
        public string PriorityName { get; set; }
        public Nullable<int> PriorityrRank { get; set; }
        public string Progress { get; set; }
        public string Column1 { get; set; }
    }
}
