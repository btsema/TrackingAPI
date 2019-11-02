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

        public enum SatisfactionFromTheLocation { Terribe = 0, Bed = 1, Acceptable = 2, Good = 3, Awsome = 4 }

        /// <summary>
        /// AI_PublicLocationType contains type of public object/institutions whose will be used in AI process for recommendation for next location
        /// </summary>
        public enum AI_PublicLocationType { EducationObject = 0, SportObject = 1, CinemaObject = 2 }
    }
}