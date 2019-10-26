using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingMyFoodAPI.Models.Requests
{
    public class AddNewCompanyRequest
    {
        public string Name { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
    }
}
