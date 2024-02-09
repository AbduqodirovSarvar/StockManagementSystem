using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class StockType : AudiTable<Guid>
    {
        public StockType() : base() { }

        public StockType(string name, string description)
            : base()
        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
