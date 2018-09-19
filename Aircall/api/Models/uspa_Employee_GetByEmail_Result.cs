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
    
    public partial class uspa_Employee_GetByEmail_Result
    {
        public int Id { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<int> StateId { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string WorkStartTime { get; set; }
        public string WorkEndTime { get; set; }
        public bool IsSalesPerson { get; set; }
        public bool IsWorkAreaAssigned { get; set; }
        public bool AppLoginStatus { get; set; }
        public string DeviceType { get; set; }
        public string DeviceToken { get; set; }
        public bool IsActive { get; set; }
        public string PasswordUrl { get; set; }
        public Nullable<System.DateTime> ResetPasswordLinkExpireDate { get; set; }
        public Nullable<bool> IsLinkActive { get; set; }
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
