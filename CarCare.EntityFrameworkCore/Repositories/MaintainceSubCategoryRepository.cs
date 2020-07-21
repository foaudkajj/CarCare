using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore.Repositories
{
    public class MaintainceSubCategoryRepository : Repository<MaintainceSubCategory>, IMaintainceSubCategoryRepository
    {
        private readonly CarCareDbContext _context;
        public MaintainceSubCategoryRepository(CarCareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
