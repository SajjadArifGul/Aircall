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
    
    public partial class uspa_ClientUnit_UnPaid_GetByClientId_Result
    {
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<decimal> PricePerMonth { get; set; }
        public string ClientName { get; set; }
        public string PlanTypeName { get; set; }
        public Nullable<int> PlanTypeId { get; set; }
        public string UnitName { get; set; }
        public Nullable<int> Status { get; set; }
        public string Address { get; set; }
        public string PaymentStatus { get; set; }
        public bool IsSpecialApplied { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> AddedByType { get; set; }
    }
}
