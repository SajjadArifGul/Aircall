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
    
    public partial class uspa_ClientPortal_GetNoShowDetail_Result
    {
        public Nullable<long> ServiceId { get; set; }
        public string ServiceCaseNumber { get; set; }
        public Nullable<decimal> NoShowAmount { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkPerformed { get; set; }
        public string ServiceType { get; set; }
    }
}