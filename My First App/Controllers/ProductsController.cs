using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_First_App.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Welcome(string name, int sectretNumber=93)
        {
            @ViewBag.Name = name;
            @ViewBag.Sectret = sectretNumber;
            return View();
        }
    }
}