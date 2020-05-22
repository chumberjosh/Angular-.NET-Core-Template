using System;

namespace DatingApp.API.Models.xTransportMap
{
    public class Agency
    {
        public int agency_id { get; set; }
        public string agency_name { get; set; }
        public string agency_url { get; set; }
        public DateTime agency_timezone { get; set; }
        public string agency_lang { get; set; }
        public string agency_phone { get; set; }
        public string fare_url { get; set; }
    }
}