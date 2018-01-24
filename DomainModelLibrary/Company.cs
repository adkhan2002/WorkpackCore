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
    
    public partial class Company
    {
        public Company()
        {
            this.Projects = new HashSet<Project>();
            this.Users = new HashSet<User>();
        }
    
        public int CompanyId { get; set; }
        public string ComanyName { get; set; }
        public string ComanyCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string RefEmailId { get; set; }
        public string HideUserAlert { get; set; }
        public string HideUserAlertDT { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public string SMTPHost { get; set; }
        public string LogoPath { get; set; }
        public int LicencesNumber { get; set; }
        public Nullable<System.DateTime> Subscriptiondate { get; set; }
        public string EnableLogo { get; set; }
        public Nullable<int> CompanyTypeID { get; set; }
        public string CompanyAddress { get; set; }
    
        public virtual CompanyProfile Profile { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
