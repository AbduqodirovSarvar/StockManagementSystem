using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class StockProduct : AudiTable<Guid>
    {
        public StockProduct() : base() { }

        public StockProduct(Guid stockId, Guid productId, decimal quantity)
            : base()
        {
            StockId = stockId;
            ProductId = productId;
            Quantity = quantity;
        }
        public Guid StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public Guid ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
        public decimal Quantity { get; set; }
    }
}
