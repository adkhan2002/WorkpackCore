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
    
    public partial class PageLineDetail
    {
        public int PageLineDetailID { get; set; }
        public Nullable<int> PageDetailID { get; set; }
        public string Color { get; set; }
        public Nullable<int> X1 { get; set; }
        public Nullable<int> X2 { get; set; }
        public Nullable<int> Y1 { get; set; }
        public Nullable<int> Y2 { get; set; }
        public Nullable<int> Weight { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual PageDetail PageDetail { get; set; }
    }
}
