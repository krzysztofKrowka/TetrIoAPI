namespace TetrIoAPI.Service.Models
{
    public class XpLeaderboard
    {
        public class Data
        {
            public List<User> users { get; set; }
        }
        public class User
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string role { get; set; }
            public string? ts { get; set; }
            public float xp { get; set; }
            public string? country { get; set; }
            public bool supporter { get; set; }
            public bool verified { get; set; }
            public double gamesplayed { get; set; }
            public double gameswon { get; set; }
            public float gametime { get; set; }
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
