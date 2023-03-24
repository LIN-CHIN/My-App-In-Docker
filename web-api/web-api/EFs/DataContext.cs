using Microsoft.EntityFrameworkCore;
using web_api.Entities;

namespace web_api.EFs
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(InsertUserSeed());
        }

        private IEnumerable<User> InsertUserSeed()
        {
            IList<User> users = new List<User>();

            users.Add(new User
            {
                UserId = 1,
                UserName = "chin"
            });

            users.Add(new User
            {
                UserId = 2,
                UserName = "reset"
            });

            return users;
        }
    }
}
