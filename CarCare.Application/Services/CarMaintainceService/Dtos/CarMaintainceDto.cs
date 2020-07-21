using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.Dtos
{
    public class CarMaintainceDto
    {
        public int Id { get; set; }
        public int KM { get; set; }
        public int CarId { get; set; }
    }
}
