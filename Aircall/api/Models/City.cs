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
    
    public partial class City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public City()
        {
            this.AreaMasters = new HashSet<AreaMaster>();
            this.BillingHistories = new HashSet<BillingHistory>();
            this.ClientAddresses = new HashSet<ClientAddress>();
            this.FailedBillingHistories = new HashSet<FailedBillingHistory>();
            this.Partners = new HashSet<Partner>();
            this.PlanSlaves = new HashSet<PlanSlave>();
            this.ZipCodes = new HashSet<ZipCode>();
        }
    
        public int Id { get; set; }
        public Nullable<int> StateId { get; set; }
        public string Name { get; set; }
        public bool ShowInClient { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public bool PendingInactive { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> AddedByType { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> UpdatedByType { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<int> DeletedByType { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaMaster> AreaMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingHistory> BillingHistories { get; set; }
        public virtual Role Role { get; set; }
        public virtual Role Role1 { get; set; }
        public virtual Role Role2 { get; set; }
        public virtual State State { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FailedBillingHistory> FailedBillingHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner> Partners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSlave> PlanSlaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZipCode> ZipCodes { get; set; }
    }
}
