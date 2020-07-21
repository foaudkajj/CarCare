using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Core.Models
{
    public class MaintainceSubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaintainceCategoryId { get; set; }
        public MaintainceCategory MaintainceCategory { get; set; }
    }
}
