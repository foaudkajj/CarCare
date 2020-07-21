using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore.Repositories
{
    public class CarModelRepository : Repository<CarModel>, ICarModelRepository
    {
        private readonly CarCareDbContext _context;
        public CarModelRepository(CarCareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
