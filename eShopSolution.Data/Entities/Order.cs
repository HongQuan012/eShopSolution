using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }

        public string OrderDate { set; get; }

        public string UserId { set; get; }

        public string ShipName { set; get; }

        public string ShipAddress { set; get; }

        public string ShipEmail { set; get; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
