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
    
    public partial class usp_getProjectTaskByProjectID_Contract_Result
    
    {
        public int id { get; set; }
        public Nullable<int> NormsID { get; set; }
        public string NormName { get; set; }
        public int DepatmentID { get; set; }
        public string DepatmentName { get; set; }
        public string TaskName { get; set; }
        public int TaskTypeID { get; set; }
        public string TaskTypeName { get; set; }
        public Nullable<int> Duration { get; set; }
        public decimal AllottedHours { get; set; }
        public string WBSID { get; set; }
        public string WBSName { get; set; }
        public Nullable<int> Priority { get; set; }
        public string PriorityName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Remarks { get; set; }
        public int NormDeptID { get; set; }
        public string TaskNo { get; set; }
        public Nullable<int> TaskStatus { get; set; }
        public string TaskStatusName { get; set; }
        public int Lock { get; set; }
        public string LastEditedBy { get; set; }
        public Nullable<bool> IsDeliverable { get; set; }
        public Nullable<int> DeliverableFileCnt { get; set; }
        public int CurrencyID { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}
