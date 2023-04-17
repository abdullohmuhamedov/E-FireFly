using E_FoodMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace E_FoodMarket.Data.Configurations;

public class DbContextApp : DbContext
{
    public DbContextApp(DbContextOptions<DbContextApp> options)
    : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<SoldFood> SoldFoods { get; set; }
}
