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
    
    public partial class CustomerCard
    {
        public int CustomerCardId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> Cardid { get; set; }
        public Nullable<int> DeskId { get; set; }
        public Nullable<int> Adminid { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Card Card { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Desk Desk { get; set; }
    }
}