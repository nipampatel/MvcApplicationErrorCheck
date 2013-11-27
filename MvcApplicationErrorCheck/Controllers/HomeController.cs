using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationErrorCheck.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error404()        
        {
            Response.StatusCode = 404;
            return View();
        }

        public ActionResult Error403()
        {
            Response.StatusCode = 403;
            return View();
        }
    }
}
