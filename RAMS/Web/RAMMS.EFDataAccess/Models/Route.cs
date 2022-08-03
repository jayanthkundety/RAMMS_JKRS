﻿using System;
using System.Collections.Generic;

namespace RAMMS.EFDataAccess.Models
{
    public partial class Route
    {
        public string Code { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public double? Kmfrom { get; set; }
        public double? Kmto { get; set; }
        public string Bound { get; set; }
        public string AscendingDirection { get; set; }
    }
}
