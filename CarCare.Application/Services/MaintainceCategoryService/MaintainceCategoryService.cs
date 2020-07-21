using AutoMapper;
using CarCare.Application.Services.Dtos;
using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.Application.Services
{
    public class MaintainceCategoryService : Service<MaintainceCategory, MaintainceCategoryDto>, IMaintainceCategoryService
    {
        private readonly IRepository<MaintainceCategory> MaintainceCategoryRepository;
        private readonly IMapper _mapper;
        public MaintainceCategoryService(IRepository<MaintainceCategory> MaintainceCategoryRepository, IMapper _mapper) : base(MaintainceCategoryRepository, _mapper)
        {
            this.MaintainceCategoryRepository = MaintainceCategoryRepository;
        }
    }
}
