using AutoMapper;
using CarImport.Core.Models.Car;
using CarImport.Core.Models.CarManufacturer;
using CarImport.Core.Models.Customer;
using CarImport.Core.Models.Order;
using CarImport.Domain.DbEntities;

namespace CarImport.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Car, CarDTO>().ReverseMap();
            CreateMap<Car, CarUpdateDTO>().ReverseMap();
            CreateMap<CarManufacturer, CarManufacturerDTO>().ReverseMap();
            CreateMap<CarManufacturer, CarManufacturerUpdateDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Order,OrderDTO>().ReverseMap();
        }
    }
}
