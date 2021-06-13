using System.Data.Entity;

namespace WingTipToysMSDN.Models
{
    public class SeasonContext : DbContext
    {
        public SeasonContext() : base("WingTipToysMSDN")
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}