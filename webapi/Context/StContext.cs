using Microsoft.EntityFrameworkCore;
using webapi.Entities;

namespace webapi.Context
{
    public class StContext : DbContext
    {
        public StContext( DbContextOptions<StContext> options) : base(options)
        {

        } 


      public DbSet<Student> Students { get; set; }
    }
}


