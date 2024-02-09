using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class InCome : AudiTable<Guid>
    {
        public InCome() : base() { }

        public Guid StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public Stock? Stock { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<InComeItem> Items { get; set; } = new HashSet<InComeItem>();
    }
}
