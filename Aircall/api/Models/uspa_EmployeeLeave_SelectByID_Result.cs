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
    
    public partial class uspa_EmployeeLeave_SelectByID_Result
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool AvailableOnHoliday { get; set; }
        public string Reason { get; set; }
        public int AddedBy { get; set; }
        public string UserName { get; set; }
        public System.DateTime AddedDate { get; set; }
    }
}
