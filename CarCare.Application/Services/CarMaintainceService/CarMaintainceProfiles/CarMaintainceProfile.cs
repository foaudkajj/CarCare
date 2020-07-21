using AutoMapper;
using CarCare.Application.Services.CarMaintainceService.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarMaintainceService.CarMaintainceProfiles
{
    public class CarMaintainceProfile : Profile
    {
        public CarMaintainceProfile()
        {
            CreateMap<CarMaintaince, CarMaintainceDto>();
        }
    }
}
