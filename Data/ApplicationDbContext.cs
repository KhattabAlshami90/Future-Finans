using FutureFinans.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureFinans.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<LoanApplication> LoanApplications { get; set; }

    }
}
