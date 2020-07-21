using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services.Dtos
{
    public class MaintainceSubCategoryDtoProfile : Profile
    {
        public MaintainceSubCategoryDtoProfile()
        {
            CreateMap<MaintainceSubCategoryDto, MaintainceSubCategory>();
        }
    }
}
