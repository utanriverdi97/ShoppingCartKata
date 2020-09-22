using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace ShoppingCartCase1
{
    public class Calculator
    {
        List<ShoppingCart> ShoppingCarts;
        
        public Calculator()
        {
            ShoppingCarts = new List<ShoppingCart>();
        }

        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            ShoppingCarts.Add(shoppingCart);
        }

        public float CalculateAll()
        {
            ShoppingCart currentCart = null;
            List<Product> currentProducts = null;
            List<float> currentQuantities = null;
            float productCost = 0;
            float deliveryCost = 0;
            float totalCost = 0;

            for (int i = 0; i < ShoppingCarts.Count; i++)
            {
                currentCart = ShoppingCarts[i];
                currentProducts = currentCart.Products;
                currentQuantities = currentCart.Quantities;

                for (int j = 0; j < currentProducts.Count; j++)
                {
                    float discount = currentProducts[j].GetDiscount();

                    productCost += currentProducts[j].price * currentQuantities[j] * (1-discount);

                    deliveryCost += currentQuantities[j];

                }

                totalCost = productCost + deliveryCost;
                float couponDiscount = 0;

                for (int j = 0; j < currentCart.Coupons.Count; j++)
                {
                    if(totalCost>currentCart.Coupons[j].minAmount)
                    {
                        couponDiscount += currentCart.Coupons[j].discount;
                    }
                }

                totalCost -= couponDiscount;

                Console.WriteLine("Cart " + (i + 1) + " :  total cost is  :  " + totalCost + "  delivery cost is  : " +(deliveryCost) + "  couponDiscount is  : " + (couponDiscount));

            }

            return totalCost;
        }

    }
}
