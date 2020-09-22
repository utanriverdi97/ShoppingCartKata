using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ShoppingCartCase1
{
    public class ShoppingCart
    {
        public List<Product> Products;
        public List<float> Quantities;
        public List<Coupon> Coupons;

        public ShoppingCart() 
        {
            Products = new List<Product>();
            Coupons = new List<Coupon>();
            Quantities = new List<float>();
        }

        public void AddProduct(Product newProduct, float quantity)
        {
            if (Products.Contains(newProduct))
            {
                Quantities[Products.IndexOf(newProduct)] += quantity;
            }
            else
            {
                Products.Add(newProduct);
                Quantities.Add(quantity);
            }
        }

        public void AddCoupon(Coupon coupon)
        {
            Coupons.Add(coupon);
        }
    }
}
