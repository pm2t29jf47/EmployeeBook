//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeBook.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeePositionSkill
    {
        public System.Guid ID { get; private set; }
        public System.Guid EmployeeID { get; set; }
        public System.Guid PositionSkillID { get; set; }
        public System.DateTime AssignmentDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual PositionSkill PositionSkill { get; set; }
    }
}
