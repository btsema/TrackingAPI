using System;
using System.Collections.Generic;
using System.Text;
using static Tracking.Data.Models.Enums;

namespace Tracking.Data.Models
{
    public class AI_Location
    {
        public Double XCoordinate { get; set; }
        public Double YCoordinate { get; set; }

        public string City { get; set; }
        public int State { get; set; }
        public AI_PublicLocationType AI_PublicLocationType { get; set; }
    }
}
