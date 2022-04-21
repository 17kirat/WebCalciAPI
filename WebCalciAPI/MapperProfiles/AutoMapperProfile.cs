using AutoMapper;
//using WebApiCalculator.Core.Domain.Entities;
//using WebApiCalculator.Models;
using WebCalciAPI.Models;

namespace WebCalciAPI.MapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CalculationModel, Calculation>();
            CreateMap<Calculation, CalculationModel>();
        }
    }
}