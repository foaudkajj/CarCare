﻿using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarModelProfiles
{
    public class CarModelProfile: Profile
    {
        public CarModelProfile()
        {
            CreateMap<CarModel, CarModelDto>();
        }
    }
}
