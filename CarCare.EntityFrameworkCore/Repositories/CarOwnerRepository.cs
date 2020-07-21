using CarCare.Core.IRepositories;
using CarCare.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore.Repositories
{
    public class CarOwnerRepository : Repository<CarOwner>, ICarOwnerRepository
    {
        private readonly CarCareDbContext _context;
        public CarOwnerRepository(CarCareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
