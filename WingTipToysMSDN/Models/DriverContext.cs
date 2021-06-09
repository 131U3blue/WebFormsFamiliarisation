using System.Data.Entity;

namespace WingTipToysMSDN.Models
{
    public class DriverContext : DbContext
    {
        public DriverContext() : base("WingTipToysMSDN")
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}