using Microsoft.EntityFrameworkCore;
namespace mypro.Models
{
    public class EmpDb : DbContext
    {
        public EmpDb(DbContextOptions<EmpDb> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
