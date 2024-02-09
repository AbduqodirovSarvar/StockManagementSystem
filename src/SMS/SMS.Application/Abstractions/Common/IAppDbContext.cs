using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using SMS.Domain.Entities;
using System.Collections.Generic;

namespace SMS.Application.Abstractions.Common
{
    public interface IAppDbContext : IDisposable
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<Stock> Stocks { get; set; }
        DbSet<StockType> StockTypes { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<StockProduct> StockProducts { get; set; }
        DbSet<Organization> Organizations { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<InCome> InComes { get; set; }
        DbSet<InComeItem> InComeItems { get; set; }
        DbSet<OutCome> OutComes { get; set; }
        DbSet<OutComeItem> OutComeItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
