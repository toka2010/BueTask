using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppi.Models
{
    public class EmployeeDB : DbContext
    {
        public EmployeeDB(DbContextOptions<EmployeeDB> options) : base(options)
        {

        }
        public DbSet<Dcandidate> dcandidates { get; set; }
    }
}
