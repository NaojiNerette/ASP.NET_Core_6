using CityInfoApi.Models;

namespace CityInfoApi
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto() 
                {
                     Id = 1,
                     Name = "New York City",
                     Description = "La capital de Estados Unidos",
                     PointOfInterestDtos =  new List<PointOfInterestDto>()
                     { 
                         new PointOfInterestDto(){ 
                            Id = 1,
                            Name = "Central Park",
                            Description = "Un parque verde y grande"
                         },
                         new PointOfInterestDto(){
                            Id = 2,
                            Name = "Empire State",
                            Description = "Un edificio grande donde está el PingPin"
                         }

                     }
                },
                new CityDto()
                {
                     Id = 2,
                     Name = "Santiago",
                     Description = "La capital de Chile",
                     PointOfInterestDtos =  new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto(){
                            Id = 3,
                            Name = "Plaza de armas",
                            Description = "Llena de gente variopinta"
                         },
                         new PointOfInterestDto(){
                            Id = 4,
                            Name = "Costanera center",
                            Description = "Un edificio grande donde vive Sauron"
                         }

                     }

                },
                 new CityDto()
                {
                     Id = 3,
                     Name = "Neo-Tokyo",
                     Description = "Esta a punto de E.X.P.L.O.T.A.R",
                     PointOfInterestDtos =  new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto(){
                            Id = 5,
                            Name = "Torre de tokyo",
                            Description = "Torre representativa de tokyo y japon"
                         },
                         new PointOfInterestDto(){
                            Id = 6,
                            Name = "Shibuya Crossing",
                            Description = "Cruce mas famoso de japon, aparece en todas las series y peliculas"
                         }

                     }
                }
            };
        
        }

    }
}
