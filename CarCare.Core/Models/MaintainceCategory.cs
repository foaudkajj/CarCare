using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Core.Models
{
    public class MaintainceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CarMaintainceAndCategory> MaintainceAndCategories { get; set; }
        public List<MaintainceSubCategory> MaintainceSubCategories { get; set; }
    }
}
