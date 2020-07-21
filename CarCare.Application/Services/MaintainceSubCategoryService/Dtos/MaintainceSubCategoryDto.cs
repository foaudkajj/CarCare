using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.Dtos
{
    public class MaintainceSubCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaintainceCategoryId { get; set; }
    }
}
