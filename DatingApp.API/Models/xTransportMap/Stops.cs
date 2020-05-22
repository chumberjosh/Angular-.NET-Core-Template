using System;

namespace DatingApp.API.Models.xTransportMap
{
    public class Stops
    {
        public string stop_id { get; set; }
        public string stop_code { get; set; }
        public string stop_name { get; set; }
        public string stop_desc { get; set; }
        public string stop_lat { get; set; }
        public string stop_lon { get; set; }
        public string zone_id { get; set; }
        public string stop_url { get; set; }
        public string location_type { get; set; }
        public string parent_station { get; set; }
        public DateTime stop_timezone { get; set; }
        public string wheelchair_boarding { get; set; }
    }
}