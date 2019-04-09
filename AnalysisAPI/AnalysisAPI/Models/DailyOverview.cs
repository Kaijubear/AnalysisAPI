using System;

namespace AnalysisAPI.Models
{
    public class DailyOverview
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public double Sales { get; set; }
        public double Budget { get; set; }

    }
}
