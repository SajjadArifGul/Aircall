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
    
    public partial class uspa_ServiceAttemptCount_GetByServiceId_Result
    {
        public int Id { get; set; }
        public long ServiceId { get; set; }
        public string AttemtFailReason { get; set; }
        public Nullable<System.DateTime> AttemptDate { get; set; }
    }
}
