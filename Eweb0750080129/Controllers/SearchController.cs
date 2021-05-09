using Eweb0750080129.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eweb0750080129.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        MyDB db = new MyDB();
        public ActionResult Index(FormCollection form)
        {
            string keyword = form["keyword"].ToString();
            ViewBag.List = db.Products.Where(q => q.productName.Contains(keyword)).ToList();
            return View();
        }
    }
}