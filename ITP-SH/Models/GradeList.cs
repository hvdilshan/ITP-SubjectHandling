//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITP_SH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GradeList
    {
        public GradeList()
        {
            this.SubjectTBs = new HashSet<SubjectTB>();
        }
    
        public string Grade { get; set; }
    
        public virtual ICollection<SubjectTB> SubjectTBs { get; set; }
    }
}
