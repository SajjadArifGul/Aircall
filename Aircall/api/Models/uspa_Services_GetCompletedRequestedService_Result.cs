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
    
    public partial class uspa_Services_GetCompletedRequestedService_Result
    {
        public long Id { get; set; }
        public string ServiceCaseNumber { get; set; }
        public string ClientName { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public string EmployeeName { get; set; }
        public string PurposeOfVisit { get; set; }
        public string RedirectedPage { get; set; }
    }
}
