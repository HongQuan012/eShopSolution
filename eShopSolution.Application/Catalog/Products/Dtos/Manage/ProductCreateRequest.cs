using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos.Manage
{
    public class ProductCreateRequest
    {
        public decimal OriginalPrice { set; get; }
        public decimal Price { get; set; }
        public decimal Stock { set; get; }
        public string Name { get; set; }
        public string Detail { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
        public string LanguageId { set; get; }
    }
}
