﻿namespace ProductApi.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Status { get; set; }
        public string SKU { get; set; }
        public DateTime CreatedDate { get; set; }
        public double RetailPrice { get; set; }
        public double SalePrice { get; set; }
        public double LowestPrice { get; set; }
    }
}
