using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int Status { get; set; }
        [Required]
        public string SKU { get; set; }
        public DateTime CreatedDate { get; set; }
        public double RetailPrice { get; set;}
        public double SalePrice { get; set;}
        public double LowestPrice { get; set;}
    }
}
