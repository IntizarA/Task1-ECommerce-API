﻿using ECommerce.Domain.Entities.Common;

namespace ECommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
       // public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
