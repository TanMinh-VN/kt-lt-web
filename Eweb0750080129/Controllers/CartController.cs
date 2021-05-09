using Eweb0750080129.Models;
using Eweb0750080129.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eweb0750080129.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        MyDB db = new MyDB();
        public ActionResult Index()
        {
            return View();
        }
        public Cart GetCart()
        {
            Cart cart = Session["cart"] as Cart;
            if (cart == null || Session["cart"] == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            return cart;

        }

        public ActionResult AddItem(int productID, int quantity)
        {
            Cart cart = Session["cart"] as Cart;
            Product product = new Product();
            product = db.Products.FirstOrDefault(q => q.productID == productID);
            if (cart != null)
            {
                cart.Add(product, quantity);
                Session["cart"] = cart;
            }
            else
            {
                cart = new Cart();
                cart.Add(product, quantity);
                Session["cart"] = cart;
            }
            return RedirectToAction("ViewCart");

        }
        public ActionResult ViewCart()
        {

            if (Session["cart"] == null)
            {
                Session["cart"] = GetCart();
                return RedirectToAction("ViewCart", "Cart");
            }
            Cart cart = Session["cart"] as Cart;
            return View(cart);
        }
        public ActionResult UpdateQuantity(FormCollection form)
        {
            Cart cart = Session["cart"] as Cart;
            int productID = int.Parse(form["ID_SanPham"]);
            int quantity = int.Parse(form["Quantity"]);
            cart.UpdateQuantity(productID, quantity);
            return RedirectToAction("ViewCart", "Cart");
        }
    }
}