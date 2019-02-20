using Microsoft.EntityFrameworkCore;
using DatingApp.Models;


namespace DatingApp.DatingApp
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }   
        public DbSet<User> Users { get; set; }
    }
}