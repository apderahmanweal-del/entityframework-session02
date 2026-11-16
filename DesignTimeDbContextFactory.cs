using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EventHub.Data
{
    public class EventHubDbContextFactory
        : IDesignTimeDbContextFactory<EventHubDbContext>
    {
        public EventHubDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<EventHubDbContext>();

            optionsBuilder.UseSqlServer(
                @"Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new EventHubDbContext(optionsBuilder.Options);
        }
    }
}