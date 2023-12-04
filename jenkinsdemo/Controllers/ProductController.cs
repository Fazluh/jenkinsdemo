using jenkinsdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jenkinsdemo.Controllers
{
    public class ProductController : Controller
    {

        // GET: Product
        public ActionResult Index()

        {
            ProductModel m = new ProductModel();
            m.ProdID = 1;
            m.Prodname = "ABC";
            return View();
        }
        public ActionResult Add()

        {
           

            return View();
        }
    }
}