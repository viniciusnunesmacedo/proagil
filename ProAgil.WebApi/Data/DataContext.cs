using Microsoft.EntityFrameworkCore;
using ProAgil.WebApi.Modelos;

namespace ProAgil.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Evento> Eventos {get;set;}

        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.Entity<IdentityUser>().ToTable("MyUsers").Property(p => p.Id).HasColumnName("UserId");
        //     modelBuilder.Entity<ApplicationUser>().ToTable("MyUsers").Property(p => p.Id).HasColumnName("UserId");
        //     modelBuilder.Entity<IdentityUserRole>().ToTable("MyUserRoles");
        //     modelBuilder.Entity<IdentityUserLogin>().ToTable("MyUserLogins");
        //     modelBuilder.Entity<IdentityUserClaim>().ToTable("MyUserClaims");
        //     modelBuilder.Entity<IdentityRole>().ToTable("MyRoles");
        // }
    }
}