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
    
    public partial class StripeErrorLog
    {
        public long Id { get; set; }
        public string ChargeId { get; set; }
        public string Code { get; set; }
        public string DeclineCode { get; set; }
        public string ErrorType { get; set; }
        public string Error { get; set; }
        public string ErrorSubscription { get; set; }
        public string Message { get; set; }
        public string Parameter { get; set; }
        public Nullable<int> Userid { get; set; }
        public Nullable<long> UnitId { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    }
}
