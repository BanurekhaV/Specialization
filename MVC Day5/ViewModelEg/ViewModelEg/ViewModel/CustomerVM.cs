using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ViewModelEg.ViewModel
{
    public class CustomerVM
    {
        [Key]
        public string CustomerID { get; set; } //customer.cs
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public int OrderID { get; set; } //order.cs
        public Nullable<System.DateTime> OrderDate {get;set;} 

    }
}