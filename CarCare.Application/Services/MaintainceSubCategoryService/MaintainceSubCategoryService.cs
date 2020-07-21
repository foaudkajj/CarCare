using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services
{
    public class MaintainceSubCategoryService : Service<MaintainceSubCategory, MaintainceSubCategoryDto>, IMaintainceSubCategoryService
    {
        private readonly IRepository<MaintainceSubCategory> MaintainceSubCategoryRepository;
        private readonly IMapper _mapper;
        public MaintainceSubCategoryService(IRepository<MaintainceSubCategory> MaintainceSubCategoryRepository, IMapper _mapper) : base(MaintainceSubCategoryRepository, _mapper)
        {
            this.MaintainceSubCategoryRepository = MaintainceSubCategoryRepository;
        }
    }
}
