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
    
    public partial class uspa_Cities_GetByStateIdStatus_Result
    {
        public int Id { get; set; }
        public Nullable<int> StateId { get; set; }
        public string StateName { get; set; }
        public string Name { get; set; }
        public bool ShowInClient { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public bool PendingInactive { get; set; }
        public Nullable<int> DisplayStatus { get; set; }
    }
}
