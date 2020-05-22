using System;

namespace DatingApp.API.Models.xTransportMap
{
    public class StopTimes
    {
        public int trip_id { get; set; }
        public DateTime arrival_time { get; set; }
        public DateTime departure_time { get; set; }
        public string stop_id { get; set; }
        public string stop_sequence { get; set; }
        public string stop_headsign { get; set; }
        public string pickup_type { get; set; }
        public string drop_off_type { get; set; }
        public string shape_dist_traveled { get; set; }
        public string timepoint { get; set; }
    }
}