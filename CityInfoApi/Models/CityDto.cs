namespace CityInfoApi.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;        
        public string? Description { get; set; } 

        public int NumberPointPointOfInterestDtos 
        {
            get 
            { 
                return PointOfInterestDtos.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointOfInterestDtos { get; set; }
            = new List<PointOfInterestDto>();

    }
}
