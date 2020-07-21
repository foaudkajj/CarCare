using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarMaintainceProfiles
{
    public class CarMaintainceProfile : Profile
    {
        public CarMaintainceProfile()
        {
            CreateMap<CarMaintaince, CarMaintainceDto>();
        }
    }
}
