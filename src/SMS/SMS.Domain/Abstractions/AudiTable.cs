using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Abstractions
{
    public abstract class AudiTable<T>
    {
        protected AudiTable() { }
        public T Id { get; set; } = default!;
        public T CreatedById { get; set; } = default!;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
