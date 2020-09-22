using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ShoppingCartCase1
{
    [TestFixture]
    public class ShoppingCartTests
    {

        static void Main(string[] args)
        {
        }

        [TestCase]
        public void Add_3_item_1_Category_1_Campaign_1_Coupon()
        {
            ShoppingCart cart1 = new ShoppingCart();

            Campaign campaign1 = new Campaign(0.5f);

            Category food = new Category("Food");
            food.addCampaign(campaign1);

            Product apple = new Product("apple", 10, food);
            Product orange = new Product("orange", 7, food);
            Product grape = new Product("grape", 5, food);

            Coupon coupon1 = new Coupon(30, 5);
            cart1.AddCoupon(coupon1);

            cart1.AddProduct(apple, 5);
           

            Calculator cal = new Calculator();

            cal.AddShoppingCart(cart1);
            float totalCost = cal.CalculateAll();


            Assert.Equals(totalCost,   50  );
        }


        [TestCase]
        public void Add_15_item_4_Category_3_Campaign_2_Coupon()
        {


            Category food = new Category("Food");
            Category electronics = new Category("Electronics");
            Category chair = new Category("Chair");
            Category furniture = new Category("Furniture");
            Category hotMeal = new Category("HotMeal");

            hotMeal.parentcategory = food;
            chair.parentcategory = furniture;


            Campaign campaign1 = new Campaign(0.07f);
            Campaign campaign2 = new Campaign(0.2f);
            Campaign campaign3 = new Campaign(0.35f);

            food.addCampaign(campaign1);
            furniture.addCampaign(campaign2);
            electronics.addCampaign(campaign3);


            Product apple = new Product("apple", 10, food);
            Product orange = new Product("orange", 7, food);
            Product grape = new Product("grape", 5, food);

            Product Computer = new Product("Computer", 5650, electronics);
            Product Mouse = new Product("Mouse", 170, electronics);
            Product SmartPhone = new Product("SmartPhone", 2600, electronics);
            Product Television = new Product("Television", 6000, electronics);

            Product GamingChair = new Product("GamingChair", 750, chair);
            Product WoodenChair = new Product("WoodenChair", 160, chair);
            Product PearSeat = new Product("PearSeat", 140, chair);

            Product WoodenTable = new Product("WoodenTable", 2000, furniture);
            Product HardboardTable = new Product("HardboardTable", 120, furniture);


            Product MacAndCheese = new Product("MacAndCheese", 25, hotMeal);
            Product HotDog = new Product("HotDog", 7, hotMeal);
            Product TripleHotDog = new Product("TripleHotDog", 14, hotMeal);


            Coupon coupon1 = new Coupon(30, 5);
            Coupon coupon2 = new Coupon(70, 18);
            Coupon coupon3 = new Coupon(100, 25);
            Coupon coupon4 = new Coupon(5000, 250);


            ShoppingCart cart1 = new ShoppingCart();
            cart1.AddCoupon(coupon1);
            cart1.AddCoupon(coupon1);
            cart1.AddProduct(apple, 5);

            ShoppingCart cart2 = new ShoppingCart();
            cart2.AddCoupon(coupon4);
            cart2.AddProduct(Television, 2);
            cart2.AddProduct(Computer, 1);
            cart2.AddProduct(WoodenTable, 5);
            cart2.AddProduct(GamingChair, 1);
            cart2.AddProduct(MacAndCheese, 10);






            Calculator cal = new Calculator();

            cal.AddShoppingCart(cart1);
            cal.AddShoppingCart(cart2);

            float totalCost = cal.CalculateAll();

            Assert.Equals(totalCost, 20125.5f);
        }
    }
}
