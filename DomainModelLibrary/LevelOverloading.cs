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
    
    public partial class LevelOverloading
    {
        public int LevelOverLoadingID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<decimal> RedBlock { get; set; }
        public Nullable<decimal> Red { get; set; }
        public Nullable<decimal> Green { get; set; }
        public Nullable<int> LoggedinUserID { get; set; }
        public Nullable<decimal> CummulativeHRBlock { get; set; }
        public Nullable<decimal> NormalWorkHr { get; set; }
        public Nullable<decimal> CurrentProjectPriorityHrs { get; set; }
    }
}
