using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Abstractions
{
    public abstract class Localizable : AudiTable<Guid>
    {
        protected Localizable() : base() { }

        protected Localizable(string nameUz, string nameEn, string nameRU)
            : base()
        {
            NameUz = nameUz;
            NameEn = nameEn;
            NameRu = nameRU;
        }
        public string NameUz { get; set; } = string.Empty;
        public string NameEn { get; set;} = string.Empty;
        public string NameRu {  get; set; } = string.Empty;
    }
}
