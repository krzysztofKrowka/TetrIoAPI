using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class UserInfoDTO
    {

        public class Data
        {
            public User User { get; set; }
        }

        public class League
        {
            public double GamesPlayed { get; set; }
            public double GamesWon { get; set; }
            public double Rating { get; set; }
            public double? Glicko { get; set; }
            public double? Rd { get; set; }
            public string Rank { get; set; }
            public string BestRank { get; set; }
            public double? Apm { get; set; }
            public double? Pps { get; set; }
            public double? Vs { get; set; }
            public bool Decaying { get; set; }
            public double Standing { get; set; }
            public double StandingLocal { get; set; }
            public string? PrevRank { get; set; }
            public double PrevAt { get; set; }
            public string? NextRank { get; set; }
            public double NextAt { get; set; }
            public double Percentile { get; set; }
            public string PercentileRank { get; set; }
        }

        public class User
        {
            public string _Id { get; set; }
            public string Username { get; set; }
            public string Role { get; set; }
            public DateTime? Ts { get; set; }
            public IEnumerable<UserInfo.Badge> Badges { get; set; }
            public float Xp { get; set; }
            public double GamesPlayed { get; set; }
            public double GamesWon { get; set; }
            public string? Country { get; set; }
            public bool? BadStanding { get; set; }
            public double SupporterTier { get; set; }
            public bool Verified { get; set; }
            public League League { get; set; }
            public double? AvatarRevision { get; set; }
            public double? BannerRevision { get; set; }
            public string? Bio { get; set; }
            public double FriendCount { get; set; }
        }
    }
}

   
