using Newtonsoft.Json;

namespace TetrIoAPI.Models
{
    public class UserRecords
    {
        public class _40l
        {
            public Record? record { get; set; }
            public double? rank { get; set; }
        }

        public class Blitz
        {
            public Record? record { get; set; }
            public double? rank { get; set; }
        }

        public class Cache
        {
            public string status { get; set; }
            public long cached_at { get; set; }
            public long cached_until { get; set; }
        }

        public class Clears
        {
            public double singles { get; set; }
            public double doubles { get; set; }
            public double triples { get; set; }
            public double quads { get; set; }
            public double realtspins { get; set; }
            public double minitspins { get; set; }
            public double minitspinsingles { get; set; }
            public double tspinsingles { get; set; }
            public double minitspindoubles { get; set; }
            public double tspindoubles { get; set; }
            public double tspdoubleriples { get; set; }
            public double tspinquads { get; set; }
            public double allclear { get; set; }
        }

        public class Data
        {
            public Records records { get; set; }
            public Zen zen { get; set; }
        }

        public class Endcontext
        {
            public double seed { get; set; }
            public double lines { get; set; }
            public double level_lines { get; set; }
            public double level_lines_needed { get; set; }
            public double inputs { get; set; }
            public double holds { get; set; }
            public Time time { get; set; }
            public double score { get; set; }
            public double zenlevel { get; set; }
            public double zenprogress { get; set; }
            public double level { get; set; }
            public double combo { get; set; }
            public double currentcombopower { get; set; }
            public double topcombo { get; set; }
            public double btb { get; set; }
            public double topbtb { get; set; }
            public double currentbtbchainpower { get; set; }
            public double tspins { get; set; }
            public double piecesplaced { get; set; }
            public Clears clears { get; set; }
            public Garbage garbage { get; set; }
            public double kills { get; set; }
            public Finesse finesse { get; set; }
            public double finalTime { get; set; }
            public string gametype { get; set; }
        }

        public class Finesse
        {
            public double combo { get; set; }
            public double faults { get; set; }
            public double perfectpieces { get; set; }
        }

        public class Garbage
        {
            public double sent { get; set; }
            public double received { get; set; }
            public double attack { get; set; }
            public double cleared { get; set; }
        }

        public class Record
        {
            public string _id { get; set; }
            public string stream { get; set; }
            public string replayid { get; set; }
            public User user { get; set; }
            public string ts { get; set; }
            public Endcontext endcontext { get; set; }
            public bool? ismulti { get; set; }
        }

        public class Records
        {
            public _40l _40l { get; set; }
            public Blitz blitz { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public string? error { get; set; }
            public Data? data { get; set; }
            public Cache? cache { get; set; }
        }

        public class Time
        {
            public double start { get; set; }
            public bool zero { get; set; }
            public bool locked { get; set; }
            public double prev { get; set; }
            public double frameoffset { get; set; }
        }

        public class User
        {
            public string _id { get; set; }
            public string username { get; set; }
        }

        public class Zen
        {
            public double level { get; set; }
            public double score { get; set; }
        }
    }
}
