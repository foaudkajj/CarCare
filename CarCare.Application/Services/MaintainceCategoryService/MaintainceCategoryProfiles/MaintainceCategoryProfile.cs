using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services
{
    public class MaintainceCategoryProfile: Profile
    {
        public MaintainceCategoryProfile()
        {
            CreateMap<MaintainceCategory, MaintainceCategoryDto>();
        }
    }
}
