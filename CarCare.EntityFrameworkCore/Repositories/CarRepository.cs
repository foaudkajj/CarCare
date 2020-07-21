using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        private readonly CarCareDbContext _context;
        public CarRepository(CarCareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
