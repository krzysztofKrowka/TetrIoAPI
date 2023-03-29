using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class NewsDTO
    {
        public class Data
        {
            public List<NewsItem> News { get; set; }
        }
        public class NewsItem
        {
            public string _Id { get; set; }
            public string Stream { get; set; }
            public string Type { get; set; }
            public object Data { get; set; }
            public string Ts { get; set; }
        }
        public class Root
        {
            public string? Error { get; set; }
            public News.Data? Data { get; set; }
        }

    }
}
