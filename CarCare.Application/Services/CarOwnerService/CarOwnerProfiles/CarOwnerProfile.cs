using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarOwnerProfiles
{
    public class CarOwnerProfile:Profile
    {
        public CarOwnerProfile()
        {
            CreateMap<CarOwner, CarOwnerDto>();
        }
    }
}
