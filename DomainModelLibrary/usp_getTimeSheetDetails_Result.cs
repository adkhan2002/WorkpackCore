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
    
    public partial class usp_getTimeSheetDetails_Result
    
    {
        public string ProjectName { get; set; }
        public string IsTransUser { get; set; }
        public string HandoverPeriod { get; set; }
        public string HandoverToAnotherPeriod { get; set; }
        public string TaskName { get; set; }
        public int ProjectTaskID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public int TaskTypeID { get; set; }
        public string TaskType { get; set; }
        public Nullable<decimal> AvailableHours { get; set; }
        public Nullable<decimal> OtHours { get; set; }
        public string MonNorm { get; set; }
        public string MonOT { get; set; }
        public string TueNorm { get; set; }
        public string TueOT { get; set; }
        public string WedNorm { get; set; }
        public string WedOT { get; set; }
        public string ThuNorm { get; set; }
        public string ThuOT { get; set; }
        public string FriNorm { get; set; }
        public string FriOT { get; set; }
        public string SatNorm { get; set; }
        public string SatOT { get; set; }
        public string SunNorm { get; set; }
        public string SunOT { get; set; }
        public Nullable<decimal> ConsumedHours { get; set; }
        public string Remarks { get; set; }
        public string Justifydeviation { get; set; }
        public Nullable<System.DateTime> TaskcancelledDate { get; set; }
    }
}
