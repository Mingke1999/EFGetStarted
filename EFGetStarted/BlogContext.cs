using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        // The following configures EF to create a Sqlite database 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=E://.Net/EFGetStarted/EFGetStarted/blogging.db");
        }
           
    }
}