using CarCare.Application.Services.CarMaintainceService.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarMaintainceService
{
    public interface ICarMaintainceService : IService<CarMaintaince, CarMaintainceDto>
    {
    }
}
