using Microsoft.EntityFrameworkCore;
using WebSecurityMag.Models;

namespace WebSecurityMag.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        protected SqlContext()
        {

        }

        public virtual DbSet<Message> Messages { get; set; }
    }
}
