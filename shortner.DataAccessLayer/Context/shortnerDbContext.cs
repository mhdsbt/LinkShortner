using Microsoft.EntityFrameworkCore;
using shortner.DataAccessLayer.Entites;

namespace shortner.DataAccessLayer.Context;

public class shortnerDbContext:DbContext
{
    public shortnerDbContext(DbContextOptions<shortnerDbContext> options):base(options)
    
    {
        
    }
    
    public DbSet<Link> Links { get; set; }

    //public DbSet<Customer> Customer { get; set;}
}