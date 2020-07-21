using AutoMapper;
using CarCare.Application.Services.CarMaintainceService.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarMaintainceService.CarMaintainceProfiles
{
    class CarMaintainceDtoProfile : Profile
    {
        public CarMaintainceDtoProfile()
        {
            CreateMap<CarMaintainceDto, CarMaintaince>();
        }
    }
}
