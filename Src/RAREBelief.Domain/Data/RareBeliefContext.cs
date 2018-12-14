using System.Data.Entity;
using RAREBelief.Domain.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RAREBelief.Domain.Data
{
    public class RareBeliefContext : IdentityDbContext<User>
    {
        public RareBeliefContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<RareBeliefContext>());
        }

        public DbSet<Node> Nodes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Node>()
                .HasMany(x => x.Countries)
                .WithMany(x => x.Nodes)
                .Map(x =>
                {
                    x.ToTable("NodeCountries");
                });

            modelBuilder.Entity<Node>()
                .HasMany(x => x.States)
                .WithMany(x => x.Nodes)
                .Map(x =>
                {
                    x.ToTable("NodeStates");
                });

            modelBuilder.Entity<Node>()
                .HasMany(x => x.Cities)
                .WithMany(x => x.Nodes)
                .Map(x =>
                {
                    x.ToTable("NodeCities");
                });
        }
    }
}
