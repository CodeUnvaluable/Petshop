//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Petshop.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int StockID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductTypeID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> amout { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> Arrival_Date { get; set; }
        public Nullable<System.DateTime> Expire_Date { get; set; }
        public string Remark { get; set; }
    }
}
