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
    
    public partial class uspa_PartnerTicketRequest_GetById_Result
    {
        public int Id { get; set; }
        public Nullable<int> PartnerId { get; set; }
        public string TicketType { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public System.DateTime AddedDate { get; set; }
        public bool Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
