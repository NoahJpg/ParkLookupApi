using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, ParkName = "Olympic National Park", Type = "National", State = "WA"},
        new Park { ParkId = 2, ParkName = "North Cascades National Park", Type = "National", State = "WA"},
        new Park { ParkId = 3, ParkName = "Tiger Mountain State Forest", Type = "State", State = "WA"},
        new Park { ParkId = 4, ParkName = "Mike Roess Gold Head Branch State Park", Type = "State", State = "FL"},
        new Park { ParkId = 5, ParkName = "Everglades National Park", Type = "National", State = "FL"}
      );
    }
  }
}