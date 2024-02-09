using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class City : AudiTable<Guid>
    {
        public City(string name, string country)
            :base()
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
        }

        public City()
            : base()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
