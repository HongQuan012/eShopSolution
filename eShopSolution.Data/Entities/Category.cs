using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    { //set ,get cho phép vừa đọc vừa ghi
        public int Id { get; set; }

        public int SortOrder { get; set; }

        public bool IsShowOnHome { get; set; }

        public int? ParentId { get; set; }

        public Status Status { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
