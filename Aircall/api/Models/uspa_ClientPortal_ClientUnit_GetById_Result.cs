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
    
    public partial class uspa_ClientPortal_ClientUnit_GetById_Result
    {
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> VisitPerYear { get; set; }
        public string ClientName { get; set; }
        public Nullable<int> PlanTypeId { get; set; }
        public string PlanTypeName { get; set; }
        public string UnitName { get; set; }
        public Nullable<int> Status { get; set; }
        public string Address { get; set; }
        public string PaymentStatus { get; set; }
        public bool IsSpecialApplied { get; set; }
        public Nullable<System.DateTime> ManufactureDate { get; set; }
        public string UnitTon { get; set; }
        public Nullable<System.DateTime> CompletedServiceDate { get; set; }
        public string CompletedServiceTime { get; set; }
        public Nullable<System.DateTime> UpcomingServiceDate { get; set; }
        public string UpcomingServiceTime { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<int> CompletedServiceCount { get; set; }
    }
}
