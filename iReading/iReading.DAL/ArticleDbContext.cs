using iReading.Entity;
using Microsoft.EntityFrameworkCore;

namespace iReading.DAL
{
    public class ArticleDbContext : DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options) { }

        private string _connection;
        public ArticleDbContext(string connection)
        {
            _connection = connection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!string.IsNullOrEmpty(_connection))
                builder.UseSqlServer(_connection);
        }

        public DbSet<Articles> Articles { get; set; }
        public DbSet<ArticleViews> ArticleViews { get; set; }
    }
}
