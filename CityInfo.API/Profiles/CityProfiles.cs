using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class CityProfiles : Profile
    {
        public CityProfiles()
        {
            CreateMap<Entites.City, Models.CityWithoutPointsOfInterestDto>();
            CreateMap<Entites.City, Models.CityDto>();
        }
    }
}
