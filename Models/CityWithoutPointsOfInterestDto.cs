namespace CityInfo.API.Models
{
    public class CityWithoutPointsOfInterestDto
    {
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
