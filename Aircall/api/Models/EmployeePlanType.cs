//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeePlanType
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PlanTypeId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual PlanType PlanType { get; set; }
    }
}
