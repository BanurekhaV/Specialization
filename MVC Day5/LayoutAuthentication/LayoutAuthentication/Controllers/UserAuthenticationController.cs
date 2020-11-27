using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAuthentication.Controllers
{
    public class UserAuthenticationController : Controller
    {
        // GET: UserAuthentication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            //from r in db.Customer r.email==frm["txtuname"].toString();
            //from u in db.register
            //where(u.EmailId==r.UserName && s.Password==r.password)selects.password
            if(frm["txtname"]=="Banu" && frm["txtpwd"]=="123")
            {
                Session["Loginstatus"] = "valid";
                Session["UserId"] = frm["txtname"];
                return RedirectToAction("Index");
            }
            else
            {
                Session["Loginstatus"] = "invalid";
                return View();
            }
        }

        public ActionResult LogOff()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}