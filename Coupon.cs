using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCase1
{
    public class Coupon
    {
        public float minAmount;
        public float discount;

        public Coupon(float minAmount, float discount)
        {
            this.minAmount = minAmount;
            this.discount = discount;
        }
    }
}
