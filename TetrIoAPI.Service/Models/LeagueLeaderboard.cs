namespace TetrIoAPI.Service.Models
{
    public class LeagueLeaderboard
    {
        public class Data
        {
            public IEnumerable<User> users { get; set;  }
        }
        public class User
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string role { get; set; }
            public float xp { get; set; }
            public string? country { get; set; }
            public bool supporter { get; set; }
            public bool verified { get; set; }
            public League league { get; set; }
        }

        public class League
        {
            public double gamesplayed { get; set; }
            public double gameswon { get; set; }
            public float rating { get; set; }
            public string rank { get; set; }
            public string bestrank { get; set; }
            public float? glicko { get; set; }
            public float? rd { get; set; }
            public float? apm { get; set; }
            public float? pps { get; set; }
            public float? vs { get; set; }
            public bool decaying { get; set; }
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
