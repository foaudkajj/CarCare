using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCare.EntityFrameworkCore
{
    public class CarCareDbContext : DbContext
    {
        public CarCareDbContext(DbContextOptions<CarCareDbContext> options) : base(options)
        {
        }
    }
}
