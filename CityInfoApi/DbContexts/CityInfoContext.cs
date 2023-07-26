using CityInfoApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfoApi.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("New York City")
                {
                    Id = 1,
                    Description = "La capital de Estados Unidos"
                },
                new City("Santiago")
                {
                    Id = 2,
                    Description = "La capital de Chile"
                },
                new City("Neo-Tokyo")
                {
                    Id = 3,
                    Description = "Esta a punto de E.X.P.L.O.T.A.R",
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("Central Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "Un parque verde y grande"
                },
                new PointOfInterest("Empire State")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "Un edificio grande donde está el PingPin"
                },
                new PointOfInterest("Plaza de armas")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "Llena de gente variopinta"
                },
                new PointOfInterest("Costanera center")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "Un edificio grande donde vive Sauron"
                },
                new PointOfInterest("Torre de tokyo")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "Torre representativa de tokyo y japon"
                },
                new PointOfInterest("Shibuya Crossing")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "Cruce mas famoso de japon, aparece en todas las series y peliculas"
                }
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
