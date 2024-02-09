using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Organization : Localizable
    {
        public Organization() 
            : base() { }

        public Organization(string name, Guid addressId)
            : base()
        {
            Name = name;
            AddressId = addressId;
        }

        public string Name { get; set; } = string.Empty;
        public Guid? ParentId { get; set; }
        public Guid AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address? Address { get; set; }
    }
}
