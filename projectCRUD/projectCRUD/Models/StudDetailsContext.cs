using Microsoft.EntityFrameworkCore;

namespace projectCRUD.Models
{
    public class StudDetailsContext : DbContext
    {
        public StudDetailsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StudBasicDetails> StudBasicDetails { get; set; }
    }
}
