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
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public string Comment1 { get; set; }
        public Nullable<int> CommentBy { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public string CommentFor { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> ChildID { get; set; }
        public string Active { get; set; }
    }
}
