using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore.Repositories
{
    public class MaintainceCategoryRepository : Repository<MaintainceCategory>, IMaintainceCategoryRepository
    {
        private readonly CarCareDbContext _context;
        public MaintainceCategoryRepository(CarCareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
