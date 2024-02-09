using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Abstractions.Common
{
    public interface ICurrentUserService
    {
        Guid Id { get; }
    }
}
