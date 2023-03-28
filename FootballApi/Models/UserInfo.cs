namespace TetrIoAPI.Models
{
    public class UserInfo
    {
        public class Connections
        {
            public Discord? discord { get; set; }
        }

        public class Data
        {
            public User user { get; set; }
        }

        public class League
        {
            public double gamesplayed { get; set; }
            public double gameswon { get; set; }
            public double rating { get; set; }
            public double? glicko { get; set; }
            public double? rd { get; set; }
            public string rank { get; set; }
            public string bestrank { get; set; }
            public double? apm { get; set; }
            public double? pps { get; set; }
            public double? vs { get; set; }
            public bool decaying { get; set; }
            public double standing { get; set; }
            public double standing_local { get; set; }
            public string? prev_rank { get; set; }
            public double prev_at { get; set; }
            public string? next_rank { get; set; }
            public double next_at { get; set; }
            public double percentile { get; set; }
            public string percentile_rank { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public string? error { get; set; }
            public Data? data { get; set; }
            public Cache? cache { get; set; }
        }

        public class Badge
        {
            public string id { get; set; }
            public string label { get; set; }
            public string? ts {  get; set; }
        }
        
        public class User
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string role { get; set; }
            public DateTime? ts { get; set; }
            public string? botmaster { get; set; }
            public IEnumerable<Badge> badges { get; set; }
            public float xp { get; set; }
            public double gamesplayed { get; set; }
            public double gameswon { get; set; }
            public double gametime { get; set; }
            public string? country { get; set; }
            public bool? badstanding { get; set; }
            public double supporter_tier { get; set; }
            public bool verified { get; set; }
            public League league { get; set; }
            public double? avatar_revision { get; set; }
            public double? banner_revision { get; set; }
            public string? bio { get; set; }
            public Connections connections { get; set; }
            public double friend_count { get; set; }
            public Distinguishment? distinguishment { get; set; }
        }
  
        public class Distinguishment
        {
            public string type { get; set; }
        } 
        
        public class Discord
        {
            public string id { get; set; }
            public string username { get; set; }
        }
    }
}

   
