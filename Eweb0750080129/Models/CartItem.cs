using Eweb0750080129.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eweb0750080129.Models
{
    public class CartItem
    {
        public Product product { get; set; }
        public int soLuong { get; set; }
    }

    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items { get { return items; } }
        public void Add(Product product, int quantity)
        {
            var item = items.FirstOrDefault(i => i.product.productID == product.productID);
            if (item == null)
            {
                items.Add(new CartItem() { product = product, soLuong = quantity });
            }
            else
            {
                item.soLuong += quantity;
            }
        }
        public void UpdateQuantity(int id, int newQuantity)
        {
            var item = items.Find(i => i.product.productID == id);
            if (item != null)
            {
                item.soLuong = newQuantity;
            }
        }
    }
}