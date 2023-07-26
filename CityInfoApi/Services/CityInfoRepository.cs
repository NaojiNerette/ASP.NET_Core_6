using CityInfoApi.DbContexts;
using CityInfoApi.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace CityInfoApi.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private readonly CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context) 
        { 
            _context = context ?? throw new ArgumentNullException(nameof(context)); 
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.Cities.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<City?> GetCityAsync(
            int cityId, 
            bool includePointOfInterest)
        {
            if (includePointOfInterest)
            { 
                return await _context.Cities.Include(c => c.PointsOfInterest)
                    .Where(c => c.Id == cityId).FirstOrDefaultAsync();
            }

            return await _context.Cities
                .Where(c => c.Id == cityId).FirstOrDefaultAsync();

        }

        public async Task<PointOfInterest?> GetPointOfInterestForCityAsync(
            int cityId, 
            int pointOfinterest)
        {
            return await _context.PointsOfInterest
                .Where(p => p.CityId == cityId && p.Id == pointOfinterest)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointOfInterestsForCityAsync(
            int cityId)
        {
            return await _context.PointsOfInterest
                .Where(p => p.CityId == cityId)
                .ToListAsync();
        }

        public async Task<bool> CityExistAsync(int cityId) 
        {
            return await _context.Cities.AnyAsync(c => c.Id == cityId);
        }

        public async Task AddPointOfInterestToCity(int cityId, PointOfInterest pointOfInterest)
        {
            var city = await GetCityAsync(cityId, false);
            if (city != null) 
            {
                city.PointsOfInterest.Add(pointOfInterest);
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0); 
        }

        public void DeletePointOfInterestAsync(PointOfInterest pointOfInterest)
        {
            _context.PointsOfInterest.Remove(pointOfInterest);
        }
    }
}
