using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LocationId { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal XYCoordinate { get; set; }
    }
}