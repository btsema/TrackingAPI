using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    public class Menu
    {
        public Guid MenuId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MenuType MenuType { get; set; }

        [JsonIgnore]
        [ForeignKey("CustomerId")]
        public virtual Company Company { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}