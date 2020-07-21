using AutoMapper;
using CarCare.Application.Services.CarService.Dto;
using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarService
{
    public class CarService : Service<Car, CarDto>, ICarService
    {
        private readonly IRepository<Car> CarRepository;
        private readonly IMapper _mapper;
        public CarService(IRepository<Car> CarRepository, IMapper _mapper) : base(CarRepository, _mapper)
        {
            this.CarRepository = CarRepository;
        }
    }
}
