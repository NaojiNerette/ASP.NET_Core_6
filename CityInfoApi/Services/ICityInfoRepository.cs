using CityInfoApi.Entities;

namespace CityInfoApi.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City?> GetCityAsync(int cityId, bool includePointOfInterest);
        Task<IEnumerable<PointOfInterest>> GetPointOfInterestsForCityAsync(int cityId);
        Task<PointOfInterest> GetPointOfInterestForCityAsync(int cityId, int pointOfinterest);
        Task<bool> CityExistAsync(int cityId);
        Task AddPointOfInterestToCity(int cityId, PointOfInterest pointOfInterest);
        Task<bool> SaveChangesAsync(); 
        void DeletePointOfInterestAsync(PointOfInterest pointOfInterest);
    }
}
