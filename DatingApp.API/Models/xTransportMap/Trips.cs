namespace DatingApp.API.Models.xTransportMap
{
    public class Trips
    {
        public int route_id { get; set; }
        public int service_id { get; set; }
        public int trip_id { get; set; }
        public string trip_headsign { get; set; }
        public string trip_short_name { get; set; }
        public int direction_id { get; set; }
        public bool wheelchair_acessible { get; set; }
        public bool bikes_allowed { get; set; }
    }
}