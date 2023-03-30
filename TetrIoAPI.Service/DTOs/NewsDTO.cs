using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class NewsDTO
    {
        public class Data
        {
            public IEnumerable<News.NewsItem> News { get; set; }
        }
    }
}
