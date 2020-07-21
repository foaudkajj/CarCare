using AutoMapper;
using CarCare.Application.Services.CarModelService.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarModelService.CarModelProfiles
{
    public class CarModelProfile: Profile
    {
        public CarModelProfile()
        {
            CreateMap<CarModel, CarModelDto>();
        }
    }
}
