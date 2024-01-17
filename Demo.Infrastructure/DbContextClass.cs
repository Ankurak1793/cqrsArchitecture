using Demo.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<CommentDTO> Comments { get; set; }

        public DbSet<BlogDTO> Blogs { get; set; }


        public DbSet<ApplicationUserDTO> ApplicationUsers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}