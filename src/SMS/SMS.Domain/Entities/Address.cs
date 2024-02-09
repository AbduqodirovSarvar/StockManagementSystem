using SMS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Address : AudiTable<Guid>
    {
        public Address(
            decimal referencePointLongitude,
            decimal referencePointLatitude,
            string block,
            string homeNumber,
            string addressLine1,
            Guid cityId
            ) 
            :base()
        {
            Id = Guid.NewGuid();
            ReferencePointLongitude = referencePointLongitude;
            ReferencePointLatitude = referencePointLatitude;
            Block = block;
            HomeNumber = homeNumber;
            AddressLine1 = addressLine1;
            CityId = cityId;
        }

        public Address()
            :base() 
        {
            Id = Guid.NewGuid();
        }
        
        public decimal ReferencePointLongitude { get; set; }
        public decimal ReferencePointLatitude { get; set; }
        public string Block { get; set; } = string.Empty;
        public string HomeNumber { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;

        public Guid CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public City? City { get; set; }
    }
}
