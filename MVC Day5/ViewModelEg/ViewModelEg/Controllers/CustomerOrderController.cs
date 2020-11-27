using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelEg.Models;
using ViewModelEg.ViewModel;

namespace ViewModelEg.Controllers
{
    public class CustomerOrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: CustomerOrder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustOrder()
        {

            List<CustomerVM> customerVMlist = new List<CustomerVM>();
            //query to get details from the database by joining 2 tables
            var customerlist = (from cust in db.Customers
                                join or in db.Orders
                                on cust.CustomerID equals or.CustomerID
                                select new { cust.CustomerID, cust.CompanyName, cust.ContactName, or.OrderID,
                                or.OrderDate }).ToList();

            //using foreach, let us fill the data in cutomervM object
            foreach(var item in customerlist)
            {
                CustomerVM objcvm = new CustomerVM(); //viewmodel class object
                objcvm.CustomerID = item.CustomerID;
                objcvm.ContactName = item.ContactName;
                objcvm.CompanyName = item.CompanyName;
                objcvm.OrderID = item.OrderID;
                objcvm.OrderDate = item.OrderDate;
                customerVMlist.Add(objcvm);
            }
            return View(customerVMlist);


        }
    }
}