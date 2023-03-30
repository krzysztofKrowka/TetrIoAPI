namespace TetrIoAPI.Service.DTOs
{
    public class ServerStatisticDTO
    {

        public class Data
        {
            public double UserCount { get; set; }
            public double AnonCount { get; set; }
            public double RankedCount { get; set; }
            public double GamesPlayed { get; set; }
            public double GamesFinished { get; set; }
        }

    }
}
