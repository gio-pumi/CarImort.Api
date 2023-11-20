using AutoMapper;
using CarImport.Core.Interfaces;
using CarImport.Core.Models.Car;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository<Car> _carRepositoryService;
        private readonly IMapper _mapper;
        private readonly ICurrencyService _currencyService;

        public CarController(ICarRepository<Car> carRepositoryService, IMapper mapper, ICurrencyService currencyService)
        {
            _carRepositoryService = carRepositoryService;
            _mapper = mapper;
            _currencyService = currencyService;
        }

        //Add car
        [HttpPost]
        public async Task<List<CarDTO>> AddCar(CarDTO carDTO)
        {
            var car = _mapper.Map<Car>(carDTO);
            var cars = await _carRepositoryService.AddAsync(car);
            var carsDTO = cars.Select(c => _mapper.Map<CarDTO>(c)).ToList();
            return carsDTO;
        }

        //Update car
        [HttpPut]
        public async Task<List<CarDTO>> UpdateCar(CarUpdateDTO carUpdateDTO)
        {
            var car = _mapper.Map<Car>(carUpdateDTO);
            var carForUpdate = await _carRepositoryService.UpdateAsync(car);
            var carsDTO = carForUpdate.Select(c => _mapper.Map<CarDTO>(c)).ToList();
            return carsDTO;
        }

        //Get all cars
        [HttpGet]
        public async Task<List<CarDTO>> GetAllCars(string currency = "USD")
        {
            var cars = await _carRepositoryService.GetAllAsync();
            var returnedCurrencies = await _currencyService.GetCurrencies();

            var target = returnedCurrencies.data.GetType().GetProperty(currency);
            var value = (float)target.GetValue(returnedCurrencies.data);

            cars.ForEach(c => c.CarCost *= (decimal)value);

            var carsDTO = cars.Select(c => _mapper.Map<CarDTO>(c)).ToList();

            return carsDTO;

        }


        ////Get car by Id
        //[HttpGet]
        //[Route("Id")]
        //public async Task<Car> GetCarById(int id)
        //{
        //    var car = await _carService.GetCarById(id);
        //    return car;
        //}

        //Delete car
        [HttpDelete]
        public async Task<List<CarDTO>> DeleteCar(int id)
        {
            await _carRepositoryService.DeleteAsync(id);
            var cars = await _carRepositoryService.GetAllAsync();

            var carsDTO = cars.Select(c => _mapper.Map<CarDTO>(c)).ToList();

            return carsDTO;
        }
    }
}
