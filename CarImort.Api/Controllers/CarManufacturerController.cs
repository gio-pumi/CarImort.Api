using AutoMapper;
using CarImport.Core.Interfaces;
using CarImport.Core.Models.CarManufacturer;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarManufacturerController : ControllerBase
    {
        private readonly ICarManufaturerRepository<CarManufacturer> _carManufaturerRepository;
        private readonly IMapper _mapper;

        public CarManufacturerController(ICarManufaturerRepository<CarManufacturer> carManufaturerRepositoryService,IMapper mapper)
        {
            _carManufaturerRepository = carManufaturerRepositoryService;
            _mapper = mapper;
        }


        //Add car manufacturer
        [HttpPost]
        public async Task<List<CarManufacturerDTO>> CreateManufacturer(CarManufacturerDTO carManufacturerDTO)
        {
            var carManufacturer = _mapper.Map<CarManufacturer>(carManufacturerDTO);
            var carManufacturers = await _carManufaturerRepository.AddAsync(carManufacturer);
            var carManufacturersDTO = _mapper.Map<List<CarManufacturerDTO>>(carManufacturers);
            return carManufacturersDTO;
        }


        //Get all car manufacturers
        [HttpGet]
        public async Task<List<CarManufacturerDTO>> GetAllCarManufacturer()
        {

            var carManufacturers = await _carManufaturerRepository.GetAllAsync();
            var carManufacturersDTO = _mapper.Map<List<CarManufacturerDTO>>(carManufacturers);
            return carManufacturersDTO;
        }

        //Get car manufacturer by Id 
        [HttpGet]
        [Route("Id")]
        public async Task<CarManufacturerDTO> GetCarManufacturerById(int Id)
        {
            var carManufacturer = await _carManufaturerRepository.GetByIdAsync(Id);
            var carManufacturerDTO= _mapper.Map<CarManufacturerDTO>(carManufacturer);

            return carManufacturerDTO;
        }


        //Update car manufacturer
        [HttpPut]
        public async Task<List<CarManufacturerDTO>> UpdateCarManufacturer(CarManufacturerUpdateDTO carmanufacturerUpdateDTO)
        {
            var carManufacturer = _mapper.Map<CarManufacturer>(carmanufacturerUpdateDTO);
            var carManufacturers = await _carManufaturerRepository.UpdateAsync(carManufacturer);
            var carManufacturersDTO = carManufacturers.Select(c => _mapper.Map<CarManufacturerDTO>(c)).ToList();
            return carManufacturersDTO;
        }


        //Delete car manufacturer
        [HttpDelete]
        public async Task<List<CarManufacturerDTO>> DeleteCarManufacturer(int id)
        {
            var carManufacturers = await _carManufaturerRepository.DeleteAsync(id);
            var carManufacturersDTO = carManufacturers.Select(c => _mapper.Map<CarManufacturerDTO>(c)).ToList();
            return carManufacturersDTO;
        }
    }
}
