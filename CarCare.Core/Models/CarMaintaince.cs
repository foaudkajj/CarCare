using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Core.Models
{
    public class CarMaintaince
    {
        public int Id { get; set; }
        public int KM { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public List<CarMaintainceAndCategory> MaintainceAndCategories { get; set; }
    }
}
