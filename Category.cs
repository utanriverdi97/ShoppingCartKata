using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCase1
{
    public class Category
    {
        public string title;
        public Category parentcategory;
        public Campaign campaign;

        public Category(string title)
        {
            this.title = title;
            parentcategory = null;
            campaign = null;
        }

        public Category(string title,Category category)
        {
            this.title = title;
            this.parentcategory = category;
            campaign = null;
        }

        public Category(string title, Category category, Campaign campaign)
        {
            this.title = title;
            this.parentcategory = category;
            this.campaign = campaign;
        }

        public void addCampaign(Campaign campaign)
        {
            this.campaign = campaign;
        }
    }
}
