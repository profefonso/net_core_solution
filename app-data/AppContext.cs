using System;
using Microsoft.EntityFrameworkCore;

namespace app_data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) 
        : base(options)
        {
        }

        protected AppContext()
        {
        }
        public DbSet<ExtendContacto> ExtendContactos { get; set; }
    }
}
