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
    
    public partial class usp_getAssignEngineers_Result
    
    {
        public int UserID { get; set; }
        public string Employee { get; set; }
        public string DesignationName { get; set; }
        public int DesignationID { get; set; }
        public Nullable<decimal> AvailableHours { get; set; }
        public Nullable<decimal> EstimatedHrs { get; set; }
        public Nullable<int> TaskStatus { get; set; }
    }
}
