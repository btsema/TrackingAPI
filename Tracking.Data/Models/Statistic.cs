using System;
using System.Collections.Generic;
using System.Text;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    public class Statistic
    {
        public Guid StatisticId { get; set; }
        public Guid CompanyUnitId { get; set; }

        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public SatisfactionFromTheLocation LevelOfSatisfaction { get; set; }

    }
}
