using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
        {
        }
       
        public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }


	}
}
