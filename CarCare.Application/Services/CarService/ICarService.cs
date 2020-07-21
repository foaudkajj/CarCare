using CarCare.Application.Services.CarService.Dto;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarService
{
    public interface ICarService : IService<Car, CarDto>
    {
    }
}
