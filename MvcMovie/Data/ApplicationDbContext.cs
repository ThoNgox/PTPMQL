using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Student> Student { get; set; } = default!;
        public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DaiLy> DaiLy { get; set; }
        public DbSet<MvcMovie.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
    }
    
}
