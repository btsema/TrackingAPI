using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    public class CompanyUnitDailyLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyUnitDailyLocationId { get; set; }
        public Guid CompanyUnitId { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public SatisfactionFromTheLocation LevelOfSatisfaction { get; set; }
        public Location Location { get; set; }

        [JsonIgnore]
        [ForeignKey("CustomerId")]
        public virtual Company Company { get; set; }

        // add here virtual list to Company
    }
}