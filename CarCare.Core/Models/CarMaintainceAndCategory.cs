using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Core.Models
{
    public class CarMaintainceAndCategory
    {
        public DateTime MaintainceDate { get; set; }
        public DateTime NextMaintainceDate { get; set; }
        public int MaintainceKM { get; set; }
        public int NextMiantainceKM { get; set; }
        public string MaintainceDescription { get; set; }
        public int MaintainceCategoryId { get; set; }
        public MaintainceCategory MaintainceCategory { get; set; }
        public int CarMaintainceId { get; set; }
        public CarMaintaince CarMaintaince { get; set; }
    }
}
