using AutoMapper;
using CarCare.Application.Services.CarModelService.Dtos;
using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarModelService
{
    public class CarModelService : Service<CarModel, CarModelDto>, ICarModelService
    {
        private readonly IRepository<CarModel> CarModelRepository;
        private readonly IMapper _mapper;
        public CarModelService(IRepository<CarModel> CarModelRepository, IMapper _mapper) : base(CarModelRepository, _mapper)
        {
            this.CarModelRepository = CarModelRepository;
        }
    }
}
