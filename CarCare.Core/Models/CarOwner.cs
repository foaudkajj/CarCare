using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Core.Models
{
    public class CarOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
