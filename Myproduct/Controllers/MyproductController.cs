using Myproduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myproduct.Controllers
{
    public class MyproductController : Controller
    {
        Myproductclass prop = new Myproductclass {
            Id = "101",
            
            category="electonics",
            
            name="bhanu",
            Orderdate=DateTime.Now,
            productprise=10,
            productquality=2
            
        };
        // GET: Myproduct
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Myaction()
        {
            return View(prop);
        }
        public ActionResult Edit()
        {
            return View(prop);
        }




    }
}