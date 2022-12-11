using System.Data.Entity;
namespace ReviewBookWpf.Services.DataBase
{
    internal class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppContext() : base("DefaultConnection") {}
    }
}
