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
    
    public partial class ContractNorm
    {
        public int ContractNormID { get; set; }
        public string NormsName { get; set; }
        public string NormsDesc { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<decimal> Mhrs { get; set; }
        public Nullable<decimal> DMF { get; set; }
        public Nullable<decimal> CFMin { get; set; }
        public Nullable<decimal> CFMax { get; set; }
        public string Unit { get; set; }
    }
}
