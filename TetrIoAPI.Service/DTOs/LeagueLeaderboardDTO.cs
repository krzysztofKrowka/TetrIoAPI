using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class LeagueLeaderboardDTO
    {

        public class Root
        {
            public string? Error { get; set; }
            public LeagueLeaderboard.Data? Data { get; set; }
        }
    }
}
