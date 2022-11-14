using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //OnePages :Tek sayfada tüm sayfaları duzenlendi.

        public ActionResult Index()
        {
            return View();
        }
       
    }
}