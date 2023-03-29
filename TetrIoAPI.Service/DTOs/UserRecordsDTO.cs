using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class UserRecordsDTO
    {
        public class _40l
        {
            public Record? Record { get; set; }
            public double? Rank { get; set; }
        }

        public class Blitz
        {
            public Record? Record { get; set; }
            public double? Rank { get; set; }
        }

        public class Data
        {
            public Records Records { get; set; }
            public UserRecords.Zen Zen { get; set; }
        }
  
        public class Record
        {
            public string _Id { get; set; }
            public string Stream { get; set; }
            public string ReplayId { get; set; }
            public UserRecords.User User { get; set; }
            public string Ts { get; set; }
        }

        public class Records
        {
            public _40l _40l { get; set; }
            public Blitz Blitz { get; set; }
        }

        public class Root
        {
            public string? Error { get; set; }
            public Data? Data { get; set; }
        }

    }
}
