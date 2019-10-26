using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    public class CompanyUnits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyUnitId { get; set; }
        public Guid CompanyId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public int XCoorinate { get; set; }
        public int YCoorinate { get; set; }
        public CompanyUnitType CompanyUnitType { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        [ForeignKey("CustomerId")]
        public virtual Company Company { get; set; }

        // add here virtual list to Company
    }
}