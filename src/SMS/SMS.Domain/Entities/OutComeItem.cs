using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class OutComeItem : AudiTable<Guid>
    {
        public OutComeItem() 
            :base()
        {
            TotalItemPrice = Quantity * Price;
        }

        public OutComeItem(Guid productId, Guid outComeId, decimal quantity, decimal price)
            :base()
        {
            ProductId = productId;
            OutComeId = outComeId;
            Quantity = quantity;
            Price = price;
            TotalItemPrice = Quantity * Price;
        }

        public Guid ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
        public Guid OutComeId { get; set; }
        [ForeignKey(nameof(OutComeId))]
        public OutCome? OutCome { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalItemPrice { get; init; }
    }
}
