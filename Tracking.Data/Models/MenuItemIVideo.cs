using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Tracking.Data.Models
{
    public class MenuItemVideo
    {
        public Guid MenuItemVideoId { get; set; }
        public Guid MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EmbeedContent { get; set; }
        public string VideoPath { get; set; }
        [JsonIgnore]
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }
    }
}
