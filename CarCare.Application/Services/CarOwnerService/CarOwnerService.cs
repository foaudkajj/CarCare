using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services
{
    public class CarOwnerService : Service<CarOwner, CarOwnerDto>, ICarOwnerService
    {
        private readonly IRepository<CarOwner> CarOwnerRepository;
        private readonly IMapper _mapper;
        public CarOwnerService(IRepository<CarOwner> CarOwnerRepository, IMapper _mapper) : base(CarOwnerRepository, _mapper)
        {
            this.CarOwnerRepository = CarOwnerRepository;
        }
    }
}
