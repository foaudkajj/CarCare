using AutoMapper;
using CarCare.Application.Services.CarMaintainceService.Dtos;
using CarCare.Application.Services.CarService;
using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarMaintainceService
{
    public class CarMaintainceService : Service<CarMaintaince, CarMaintainceDto>, ICarMaintainceService
    {
        private readonly IRepository<CarMaintaince> CarMaintainceRepository;
        private readonly IMapper _mapper;
        public CarMaintainceService(IRepository<CarMaintaince> CarMaintainceRepository, IMapper _mapper) : base(CarMaintainceRepository, _mapper)
        {
            this.CarMaintainceRepository = CarMaintainceRepository;
        }
    }
}
