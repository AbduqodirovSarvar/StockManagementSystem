using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Product : Localizable
    {
        public Product() : base() { }

        public Product(
            decimal originalPrice,
            decimal salePrice,
            decimal percentage,
            Guid categoryId
            ) : base()
        { 
            OriginalPrice = originalPrice;
            SalePrice = salePrice;
            Percentage = percentage;
            CategoryId = categoryId;
        }
        public decimal OriginalPrice {  get; set; }
        public decimal SalePrice { get; set; }
        public decimal Percentage { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }
    }
}
