using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.MaintainceCategoryProfiles
{
    public class MaintainceCategoryDtoProfile: Profile
    {
        public MaintainceCategoryDtoProfile()
        {
            CreateMap<MaintainceCategory, MaintainceCategoryDto>();
        }
    }
}
