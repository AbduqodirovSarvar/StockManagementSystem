using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class OutCome : AudiTable<Guid>
    {
        public OutCome()
            : base()
        {
            TotalPrice = Items.Sum(x => x.TotalItemPrice);
        }

        public OutCome(Guid stockId, ICollection<InComeItem> items)
        {
            StockId = stockId;
            TotalPrice = Items.Sum(x => x.TotalItemPrice); 
            Items = items;
        }

        public Guid StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public Stock? Stock { get; set; }
        public decimal TotalPrice { get; init; }
        public ICollection<InComeItem> Items { get; set; } = new HashSet<InComeItem>();
    }
}
