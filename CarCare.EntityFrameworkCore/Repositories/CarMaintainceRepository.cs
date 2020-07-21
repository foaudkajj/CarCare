using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore.Repositories
{
    public class CarMaintainceRepository : Repository<CarMaintaince>, ICarMaintainceRepository
    {
        private readonly CarCareDbContext _context;
        public CarMaintainceRepository(CarCareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
