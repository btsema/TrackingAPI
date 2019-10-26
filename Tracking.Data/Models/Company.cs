using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    /// <summary>
    /// DB Model for company. This table will contains basic information for the company 
    /// </summary>
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Web { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        /// <summary>
        /// This property will define if the company is active or not
        /// </summary>
        public CompanyStatus Status { get; set; }

        public virtual ICollection<CompanyUnits> CompanyUnits { get; set; }
    }
}
