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
    
    public partial class UnitExtraInfo
    {
        public long Id { get; set; }
        public Nullable<int> UnitId { get; set; }
        public string ExtraInfoType { get; set; }
        public Nullable<int> PartId { get; set; }
        public Nullable<bool> LocationOfPart { get; set; }
        public Nullable<long> ClientUnitPartId { get; set; }
    
        public virtual ClientUnit ClientUnit { get; set; }
        public virtual ClientUnitPart ClientUnitPart { get; set; }
        public virtual Part Part { get; set; }
    }
}
