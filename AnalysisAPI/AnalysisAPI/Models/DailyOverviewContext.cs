using Microsoft.EntityFrameworkCore;

namespace AnalysisAPI.Models
{
    public class DailyOverviewContext : DbContext
    {
        public DailyOverviewContext(DbContextOptions<DailyOverviewContext> options)
            : base(options)
        {
        }

        public DbSet<DailyOverview> Overviews { get; set; }
    }
}