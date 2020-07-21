using CarCare.Application.Services.CarModelService.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarModelService
{
    public interface ICarModelService : IService<CarModel, CarModelDto>
    {
    }
}
