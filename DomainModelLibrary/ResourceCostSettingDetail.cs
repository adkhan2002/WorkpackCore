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
    
    public partial class ResourceCostSettingDetail
    {
        public int ResourceCostSettingDetailID { get; set; }
        public Nullable<int> ResourceCostSettingID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> DesignationID { get; set; }
        public Nullable<decimal> Rate { get; set; }
    
        public virtual ResourceCostSetting ResourceCostSetting { get; set; }
    }
}
