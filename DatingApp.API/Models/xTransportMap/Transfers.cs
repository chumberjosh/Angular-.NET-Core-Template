namespace DatingApp.API.Models.xTransportMap
{
    public class Transfers
    {
        public string from_stop_id { get; set; }
        public string to_stop_id { get; set; }
        public string transfer_type { get; set; }
        public string min_transfer_time { get; set; }
    }
}