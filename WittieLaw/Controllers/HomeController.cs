using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WittieLaw.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Bankruptcy()
        {

            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
      
        public ActionResult Contact(FormCollection inquiry)
        {
            string fullname = string.Empty;
            string email = string.Empty;
            string message = string.Empty;
             fullname = inquiry["name"];
             email = inquiry["emailaddress"];
            message = inquiry["message"];
            if(!(fullname =="" || fullname==null) && !(email=="" || email==null))
            Email.sendmail(message, fullname, email.Trim());
            
            return View();
        }

    }
}
