//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS_Datas
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerPoint
    {
        public int CustomerPointsId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> PointsDate { get; set; }
        public Nullable<int> AdminId { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> TransactionId { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TransactionDetail TransactionDetail { get; set; }
    }
}
