using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Core.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string ChassisNo { get; set; }
        public string Plate { get; set; }
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
        public int CarOwnerId { get; set; }
        public CarOwner CarOwner { get; set; }
    }
}
