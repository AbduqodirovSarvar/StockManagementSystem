using Microsoft.AspNetCore.Identity;
using SMS.Domain.Abstractions;
using SMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public User() 
            : base()
        {
            Id = Guid.NewGuid();
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly BirthDay { get; set; }
        public Gender Gender { get; set; }
        public Guid CreatedById {  get; set; }
        public Guid? UpdateById { get; set; }
        public DateTime CreatedTime { get; init; } = DateTime.UtcNow;
    }
}
