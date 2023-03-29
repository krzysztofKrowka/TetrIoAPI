namespace TetrIoAPI.Service.DTOs
{
    public class ServerActivityDTO
    {
        public class Data
        {
            public List<double> Activity { get; set; }
        }

        public class Root
        {
            public string? Error { get; set; }
            public Data? Data { get; set; }
        }
    }
}
