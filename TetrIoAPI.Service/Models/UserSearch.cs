namespace TetrIoAPI.Service.Models
{
    public class UserSearch
    {
        public class Data
        {
            public User? user { get; set; }
        }
        public class User
        {
            public string _id { get; set; }
            public string username { get; set; }
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
