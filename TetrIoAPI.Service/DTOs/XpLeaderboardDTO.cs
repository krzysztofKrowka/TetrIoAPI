using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class XpLeaderboardDTO
    {
  
        public class Root
        {
            public string? Error { get; set; }
            public XpLeaderboard.Data? Data { get; set; }
        }
    }
}
