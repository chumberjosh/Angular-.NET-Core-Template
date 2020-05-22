using System;

namespace DatingApp.API.Models.xTransportMap
{
    public class Calendar
    {
        public string service_id { get; set; }
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
        public string saturday { get; set; }
        public string sunday { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }
}