using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Management.Models;

namespace Management.Data
{
    public class ManagementContext : DbContext
    {
        public ManagementContext (DbContextOptions<ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Management.Models.Department> Department { get; set; } = default!;
        public DbSet<Management.Models.Employee> Employee { get; set; } = default!;
    }
}
