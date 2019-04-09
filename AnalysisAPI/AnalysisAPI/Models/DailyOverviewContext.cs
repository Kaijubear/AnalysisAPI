using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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