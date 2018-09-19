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
    
    public partial class uspa_Services_SelectByID_Result
    {
        public long Id { get; set; }
        public string ServiceCaseNumber { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string OfficeNumber { get; set; }
        public Nullable<int> PlanTypeId { get; set; }
        public Nullable<int> DriveTime { get; set; }
        public Nullable<int> ServiceTimeForFirstUnit { get; set; }
        public Nullable<int> ServiceTimeForAdditionalUnits { get; set; }
        public string ClientAddress { get; set; }
        public int AddressID { get; set; }
        public string PurposeOfVisit { get; set; }
        public Nullable<int> WorkAreaId { get; set; }
        public string AreaName { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeImage { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public string ScheduleStartTime { get; set; }
        public string ScheduleEndTime { get; set; }
        public string CustomerComplaints { get; set; }
        public string DispatcherNotes { get; set; }
        public string TechnicianNotes { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> StatusChangeDate { get; set; }
        public Nullable<int> ScheduledBy { get; set; }
        public Nullable<int> ReportCount { get; set; }
        public System.DateTime AddedDate { get; set; }
        public bool IsNoShow { get; set; }
        public int ServiceDayGap { get; set; }
        public Nullable<int> HourDifference { get; set; }
        public Nullable<bool> IsRequestedService { get; set; }
        public Nullable<long> RequestId { get; set; }
    }
}
