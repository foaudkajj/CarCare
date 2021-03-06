﻿using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services
{
    public interface ICarModelService : IService<CarModel, CarModelDto>
    {
    }
}
