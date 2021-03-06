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
    
    public partial class ClientPaymentMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientPaymentMethod()
        {
            this.ClientUnitSubscriptions = new HashSet<ClientUnitSubscription>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public string CardType { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public Nullable<short> ExpiryMonth { get; set; }
        public Nullable<int> ExpiryYear { get; set; }
        public Nullable<bool> IsDefaultPayment { get; set; }
        public bool IsExpirationNotificationSent { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> AddedByType { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> UpdatedByType { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string CustomerPaymentProfileId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Role Role { get; set; }
        public virtual Role Role1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientUnitSubscription> ClientUnitSubscriptions { get; set; }
    }
}
