using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WildOasis.Application.Common.Interfaces;
using WildOasis.Domain.Entities;

namespace WildOasis.Infrastructure.Contexts;

public class WildOasisDbContext(DbContextOptions<WildOasisDbContext>options)
    : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
            ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>,
            IdentityUserToken<string>>(options), IWildOasisDbContext
{



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //builder.ApplyConfigurationsFromAssembly(typeof(WilaOasisDbContext).Assembly);

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Test")
        {
<<<<<<< HEAD
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=WildOasis");
=======
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=WildOasis3");
>>>>>>> d97c0336efdef8331a04e8edf1823e0753d0fdc9
        }
    }
    public DbSet<Cabin> Cabins => Set<Cabin>();
    public DbSet<Resort> Resorts => Set<Resort>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        var result = await base.SaveChangesAsync(cancellationToken);
        return result;
    }
}