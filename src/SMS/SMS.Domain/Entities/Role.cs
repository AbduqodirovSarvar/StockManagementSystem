using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public Role() 
            : base()
        {
            Id = Guid.NewGuid();
        }
    }
}
