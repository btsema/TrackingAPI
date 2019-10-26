using System;
using System.Collections.Generic;
using System.Text;

namespace Tracking.Data.Models
{
    public class Enums
    {
        public enum CompanyStatus { Active = 0, NotActiveButSearchable = 1, NotActiveNotSearchable = 2 }

        public enum CompanyUnitType { Static = 0, Mobile = 1 }

        public enum MenuType { SeaFood = 0, Pizza = 1, Meat = 2, Combine = 3, Vegetarion = 4 }

    }
}