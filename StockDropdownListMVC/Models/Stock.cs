//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockDropdownListMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Stock
    {
        public int Id { get; set; }
        public string StockId { get; set; }

        [DisplayName("Product")]
        public int ProductId { get; set; }
        public int Count { get; set; }

        [NotMapped]
        public List<Product> ProductCollection { get; set; }
    }
}
