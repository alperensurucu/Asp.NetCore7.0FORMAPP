﻿namespace Asp.NetCore7._0FORMAPP.Models
{
    public class Product
    {
        public int ProductI { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }     
    }
}
