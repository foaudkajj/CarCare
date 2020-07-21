using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.CarService.Dto
{
    public class CarDto
    {
        public int Id { get; set; }
        public string ChassisNo { get; set; }
        public string Plate { get; set; }
        public int CarModelId { get; set; }
        public int CarOwnerId { get; set; }
    }
}
