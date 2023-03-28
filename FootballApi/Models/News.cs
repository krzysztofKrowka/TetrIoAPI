namespace TetrIoAPI.Models
{
    public class News
    {
        public class Data
        {
            public List<NewsItem> news { get; set; }
        }
        public class NewsItem
        {
            public string _id { get; set; }
            public string stream { get; set; }
            public string type { get; set; }
            public object data { get; set; }
            public string ts { get; set; }
        }
        public class Root
        {
            public bool success { get; set; }
            public string? error { get; set; }
            public Data? data { get; set; }
            public Cache? cache { get; set; }
        }

    }
}
