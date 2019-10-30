using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Tracking.Data.Models
{
    public class MenuItemImage
    {
        public Guid MenuItemImageId { get; set; }
        public Guid MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        [JsonIgnore]
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }
    }
}