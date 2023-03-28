namespace TetrAPI.Models
{
    public class User
    {
        public string? _id { get; set; }
        public string? username { get; set; }
        public string? role { get; set; }
        public DateTime? ts { get; set; }
        public List<object>? badges { get; set; }
        public int? xp { get; set; }
        public int? gamesplayed { get; set; }
        public int? gameswon { get; set; }
        public double? gametime { get; set; }
        public string? country { get; set; }
        public int? supporter_tier { get; set; }
        public bool? verified { get; set; }
        public League? league { get; set; }
        public Connections? connections { get; set; }
        public int? friend_count { get; set; }
    }
}
