namespace TetrAPI.Models
{
    public class League
    {
        public int? gamesplayed { get; set; }
        public int? gameswon { get; set; }
        public double? rating { get; set; }
        public double? glicko { get; set; }
        public double? rd { get; set; }
        public string? rank { get; set; }
        public string? bestrank { get; set; }
        public double? apm { get; set; }
        public double? pps { get; set; }
        public double? vs { get; set; }
        public bool? decaying { get; set; }
        public int? standing { get; set; }
        public int? standing_local { get; set; }
        public object? prev_rank { get; set; }
        public int? prev_at { get; set; }
        public object? next_rank { get; set; }
        public int? next_at { get; set; }
        public double? percentile { get; set; }
        public string? percentile_rank { get; set; }
    }

}
