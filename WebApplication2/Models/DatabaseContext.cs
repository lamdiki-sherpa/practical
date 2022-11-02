
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
       
      /*  public DbSet<User>Users { get; set; }*/

        public DbSet<Item>products { get; set; }
      
    }
}
