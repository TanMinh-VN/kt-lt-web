using Eweb0750080129.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eweb0750080129.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product\
        MyDB db = new MyDB();
        public ActionResult Index()
        {
            ViewBag.List = db.Products.ToList();
            return View();
        }
        public ActionResult detail(int productID)
        {
            Product product = db.Products.FirstOrDefault(q => q.productID == productID);
            ViewBag.List = db.Products.OrderBy(q => q.productName).ToList();
            return View(product);
        }
    }
}