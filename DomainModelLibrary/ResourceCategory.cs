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
    
    public partial class ResourceCategory
    {
        public ResourceCategory()
        {
            this.ResourceCostSettings = new HashSet<ResourceCostSetting>();
        }
    
        public int ResourceCategoryID { get; set; }
        public string CategoryName { get; set; }
    
        public virtual ICollection<ResourceCostSetting> ResourceCostSettings { get; set; }
    }
}
