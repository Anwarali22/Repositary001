using CQRSpattern.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSpattern.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
       

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
