using System.ComponentModel.DataAnnotations;

namespace CityInfoApi.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "Yoy should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }

    }
}
