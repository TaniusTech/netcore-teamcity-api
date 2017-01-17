﻿using System;

namespace NetCoreTeamCity.Models
{
    internal class Build
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string State { get; set; }
        public string BuildTypeId { get; set; }
        public string Href { get; set; }
        public string WebUrl { get; set; }
        public string StatusText { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime QueuedDate { get; set; }
    }
}
