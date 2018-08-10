using ParksLocator.DAL.Entities;
using System.Data.Entity;

namespace ParksLocator.DAL
{
    public class ParksLocatorContext : DbContext
    {
        public ParksLocatorContext() : base("ParksLocator")
        {
            Database.SetInitializer(new ParksLocatorInitializer());
        }

        public DbSet<ParkCoordinates> Parks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkCoordinates>()
                .Property(X => X.Latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ParkCoordinates>()
                .Property(X => X.Longitude)
                .HasPrecision(18, 10);

            base.OnModelCreating(modelBuilder);
        }
    }
}
