using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Tracking.Data.Models
{
    public class MenuItem
    {
        public Guid MenuItemId { get; set; }
        public Guid MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? NumberOfCalories { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        [ForeignKey("MenuId")]
        public virtual Menu Menu { get; set; }
    }
}
