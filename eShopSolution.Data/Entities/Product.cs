using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int id { set; get; }

        public decimal Price { set; get; }

        public decimal Stock { set; get; }

        public int ViewCount { set; get; }

        public DateTime DateCreated { set; get; }

        public string SeoAlias { set; get; }

    }
}
