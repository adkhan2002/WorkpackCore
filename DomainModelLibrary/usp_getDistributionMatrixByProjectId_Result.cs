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
    
    public partial class usp_getDistributionMatrixByProjectId_Result
    
    {
        public int DocumentFiltersID { get; set; }
        public Nullable<int> DocDeptId { get; set; }
        public string DocDeptName { get; set; }
        public Nullable<int> DocMilestoneID { get; set; }
        public string MilestoneName { get; set; }
        public Nullable<int> DocRevisionID { get; set; }
        public string RevisionName { get; set; }
        public Nullable<int> DocPriorityId { get; set; }
        public string DocPriorityName { get; set; }
        public Nullable<int> DocTaskTypeId { get; set; }
        public string DocTaskType { get; set; }
        public int ProjectID { get; set; }
        public Nullable<int> RecDeptId { get; set; }
        public string RecDeptName { get; set; }
        public Nullable<int> RecDesgnId { get; set; }
        public string RecDesgnName { get; set; }
        public Nullable<int> RecRoleId { get; set; }
        public string RecRolenName { get; set; }
        public string IndividualRecipients { get; set; }
        public string ActionVal { get; set; }
    }
}
