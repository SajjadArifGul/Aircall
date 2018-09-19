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
    
    public partial class uspa_Parts_CheckParts_Result
    {
        public int Id { get; set; }
        public string InventoryType { get; set; }
        public Nullable<int> DailyPartListMasterId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public Nullable<int> InboundQuantity { get; set; }
        public Nullable<int> ReceivedQuantity { get; set; }
        public Nullable<int> TotalAcquiredQuantity { get; set; }
        public Nullable<int> InStockQuantity { get; set; }
        public Nullable<int> ReservedQuantity { get; set; }
        public Nullable<decimal> PurchasedPrice { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
        public Nullable<int> MinReorderQuantity { get; set; }
        public Nullable<int> ReorderQuantity { get; set; }
        public bool Status { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> AddedByType { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> UpdatedByType { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<int> DeletedByType { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    }
}
