namespace TetrIoAPI.Service.Models
{
    public class ServerActivity
    {
        public class Data
        {
            public List<double> activity { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public string? error { get; set; }
            public Data? data { get; set; }
            public Cache? cache { get; set; }
        }
    }
}
