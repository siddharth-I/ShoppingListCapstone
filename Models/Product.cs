﻿using System;
using System.Collections.Generic;

namespace ShoppingList.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string UnitDesc { get; set; }
        public decimal? Price { get; set; }
    }
}
