//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyPhongNet.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDrink
    {
        public string ClientName { get; set; }
        public int DrinkID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> PriceTotal { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Drink Drink { get; set; }
    }
}
