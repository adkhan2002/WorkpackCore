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
    
    public partial class UserSkillInformation
    {
        public int UserSkillInformationID { get; set; }
        public string Skills { get; set; }
        public Nullable<int> ExperienceInMonth { get; set; }
        public string Level { get; set; }
        public Nullable<int> UserID { get; set; }
        public string SkillList { get; set; }
    
        public virtual User User { get; set; }
    }
}
