using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarModelProfiles
{
    public class CarModelDtoProfile:Profile
    {
        public CarModelDtoProfile()
        {
            CreateMap<CarModelDto, CarModel>();
        }
    }
}
