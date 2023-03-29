using TetrIoAPI.Service.Models;

namespace TetrIoAPI.Service.DTOs
{
    public class UserSearchDTO
    {

        public class Root
        {
            public string? Error { get; set; }
            public UserSearch.Data? Data { get; set; }
        }
    }
}
