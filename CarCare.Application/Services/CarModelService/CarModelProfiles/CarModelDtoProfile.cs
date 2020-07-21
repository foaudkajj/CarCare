using AutoMapper;
using CarCare.Application.Services.CarModelService.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarModelService.CarModelProfiles
{
    public class CarModelDtoProfile:Profile
    {
        public CarModelDtoProfile()
        {
            CreateMap<CarModelDto, CarModel>();
        }
    }
}
