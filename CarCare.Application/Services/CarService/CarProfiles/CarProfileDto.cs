using AutoMapper;
using CarCare.Application.Services.CarService.Dto;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarService.CarProfiles
{
    public class CarProfileDto : Profile
    {
        public CarProfileDto()
        {
            CreateMap<CarDto, Car>();
        }
    }
}
