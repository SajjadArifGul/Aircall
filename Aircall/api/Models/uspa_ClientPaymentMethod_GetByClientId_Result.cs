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
    
    public partial class uspa_ClientPaymentMethod_GetByClientId_Result
    {
        public int Id { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryMonth { get; set; }
        public Nullable<int> ExpiryYear { get; set; }
        public Nullable<bool> IsDefaultPayment { get; set; }
        public string CustomerPaymentProfileId { get; set; }
        public string CardType { get; set; }
    }
}
