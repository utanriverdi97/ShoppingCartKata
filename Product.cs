using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ShoppingCartCase1
{
    public class Product
    {
        public  string title;
        public float price;
        public Category category;


        public Product(string title,float price,Category category)
        {
            this.title = title;
            this.price = price;
            this.category = category;
        }
        public Product()
        {

        }

        public float GetDiscount()
        {
            if (category.campaign == null && category.parentcategory == null)
                return 0;

            if(category.campaign!=null)
                return category.campaign.discount;


            Category parentCategory = category.parentcategory; ;

            do
            {
                if (parentCategory.campaign != null)
                    return parentCategory.campaign.discount;

                parentCategory = parentCategory.parentcategory;

            }
            while (parentCategory.parentcategory != null);


            return 0;
        }
    }
}
