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
    
    public partial class uspa_Plan_GetByPlanTypeId_Result
    {
        public int Id { get; set; }
        public Nullable<int> PlanTypeId { get; set; }
        public bool PackageType { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string PackageDisplayName { get; set; }
        public string Description { get; set; }
        public decimal PricePerMonth { get; set; }
        public short DurationInMonth { get; set; }
        public short NumberOfService { get; set; }
        public short FirstServiceWithinDays { get; set; }
        public Nullable<int> OtherServiceScheduleDaysGap { get; set; }
        public bool ShowSpecialPrice { get; set; }
        public bool ShowAutoRenewal { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<int> Drivetime { get; set; }
        public Nullable<int> ServiceTimeForFirstUnit { get; set; }
        public Nullable<int> ServiceTimeForAdditionalUnits { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public string BackGroundColorRGB { get; set; }
        public string BackGroundColorHGS { get; set; }
        public string StripePlanId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVisible { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> AddedByType { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> UpdatedByType { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<int> DeletedByTypes { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string ServiceSlot1 { get; set; }
        public string ServiceSlot2 { get; set; }
    }
}
