namespace TetrIoAPI.Models
{
    public class ServerStatistic
    {
        public class Cache
        {
            public string status { get; set; }
            public long cached_at { get; set; }
            public long cached_until { get; set; }
        }

        public class Data
        {
            public double usercount { get; set; }
            public double usercount_delta { get; set; }
            public double anoncount { get; set; }
            public double rankedcount { get; set; }
            public double replaycount { get; set; }
            public double gamesplayed { get; set; }
            public double gamesplayed_delta { get; set; }
            public double gamesfinished { get; set; }
            public double gametime { get; set; }
            public long inputs { get; set; }
            public long piecesplaced { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public Data data { get; set; }
            public Cache cache { get; set; }
        }
        /* public class Data
         {
             public double usercount { get; set; }
             public double usercount_delta { get; set; }
             public double anoncount { get; set; }
             public double rankedcount { get; set; }
             public double replaycount { get; set; }
             public double gamesplayed { get; set; }
             public double gamesplayed_delta { get; set; }
             public double gamesfinished { get; set; }
             public double gametime { get; set; }
             public long inputs { get; set; }
             public long piecesplaced { get; set; }
         }

         public class Root
         {
             public bool success { get; set; }
             public string? error { get; set; }
             public Data? data { get; set; }
             public Cache? cache { get; set; }
         }
     */
    }
}
