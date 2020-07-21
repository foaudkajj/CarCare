using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.MaintainceSubCategoryProfiles
{
    public class MaintainceSubCategoryProfile: Profile
    {
        public MaintainceSubCategoryProfile()
        {
            CreateMap<MaintainceSubCategory, MaintainceSubCategoryDto>();
        }
    }
}
