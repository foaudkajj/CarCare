using AutoMapper;
using CarCare.Application.Services.CarService.Dto;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarService.AutoMapperProfiles
{
    public class ToCarProfile : Profile
    {
        public ToCarProfile()
        {
            CreateMap<CarDto, Car>();
        }
    }
}
