using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Stock : Localizable
    {
        public Stock() : base() { }

        public Guid OrganizationId { get; set; }
        [ForeignKey(nameof(OrganizationId))]
        public Organization? Organization { get; set; }
        public Guid? StockTypeId {  get; set; }
        [ForeignKey(nameof(StockTypeId))]
        public StockType? StockType { get; set; }
    }
}
