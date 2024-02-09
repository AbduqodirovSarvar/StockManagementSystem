using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class InComeItem : AudiTable<Guid>
    {
        public InComeItem() : base() { }

        public Guid ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
        public Guid InComeId { get; set; }
        [ForeignKey(nameof(InComeId))]
        public InCome? InCome { get; set; }
        public decimal Quantity {  get; set; }
        public decimal Price { get; set; }
        public decimal TotalItemPrice { get; set; }
    }
}
