using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static TetrIoAPI.Models.News;
using static TetrIoAPI.Models.LeagueLeaderboard;
using static TetrIoAPI.Models.XpLeaderboard;
using static TetrIoAPI.Models.UserInfo;
using static TetrIoAPI.Models.UserRecords;
using static TetrIoAPI.Models.UserSearch;
using static TetrIoAPI.Models.ServerActivity;
using static TetrIoAPI.Models.ServerStatistic;
using TetrIoAPI.Models;

namespace TetrIoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TetrController : ControllerBase
    {
        private HttpClient client = new HttpClient();
        private string link = "https://ch.tetr.io/api";

        private readonly ILogger<TetrController> _logger;

        public TetrController(ILogger<TetrController> logger)
        {
            _logger = logger;
        }





        [HttpGet("/general/stats")]
        public async Task<ActionResult<string>> GetStats()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/general/stats");
            string responseBody = await response.Content.ReadAsStringAsync();
           // return Ok(responseBody);
            ServerStatistic.Root usersResponseBody = JsonConvert.DeserializeObject<ServerStatistic.Root>(responseBody);
            return Ok(usersResponseBody);
        }



        [HttpGet("/general/activity")]
        public async Task<ActionResult<string>> GetActivity()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/general/activity");
            string responseBody = await response.Content.ReadAsStringAsync();
            ServerActivity.Root usersResponseBody = JsonConvert.DeserializeObject<ServerActivity.Root>(responseBody);
            return Ok(usersResponseBody);
        }

        
        [HttpGet("/users/{user}")]
        public async Task<ActionResult<string>> GetUser(string user)
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/{user}");
            string responseBody = await response.Content.ReadAsStringAsync();
            UserInfo.Root usersResponseBody = JsonConvert.DeserializeObject<UserInfo.Root>(responseBody);
            return Ok(usersResponseBody);
        }



        [HttpGet("/users/{user}/records")]
        public async Task<ActionResult<string>> GetUserRecords(string user)
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/{user}/records");
            string responseBody = await response.Content.ReadAsStringAsync();
            UserRecords.Root usersResponseBody = JsonConvert.DeserializeObject<UserRecords.Root>(responseBody);
            return Ok(usersResponseBody);
        }



        [HttpGet("/users/search/{query}")]
        public async Task<ActionResult<string>> GetUserByDiscord(string query)
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/search/{query}");
            string responseBody = await response.Content.ReadAsStringAsync();
            UserSearch.Root usersResponseBody = JsonConvert.DeserializeObject<UserSearch.Root>(responseBody);
            return Ok(usersResponseBody);
        }



        [HttpGet("/users/lists/league")]
        public async Task<ActionResult<string>> GetLeagueLeaderboard()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/lists/league");
            string responseBody = await response.Content.ReadAsStringAsync();
            LeagueLeaderboard.Root usersResponseBody = JsonConvert.DeserializeObject<LeagueLeaderboard.Root>(responseBody);
            return Ok(usersResponseBody);
        }


        [HttpGet("/users/lists/league/all")]
        public async Task<ActionResult<string>> GetFullLeagueLeaderboard()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/lists/league/all");
            string responseBody = await response.Content.ReadAsStringAsync();
            LeagueLeaderboard.Root usersResponseBody = JsonConvert.DeserializeObject<LeagueLeaderboard.Root>(responseBody);
            return Ok(usersResponseBody);
        }


        [HttpGet("/users/lists/xp")]
        public async Task<ActionResult<string>> GetXpLeaderboard()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/lists/xp");
            string responseBody = await response.Content.ReadAsStringAsync();
            XpLeaderboard.Root usersResponseBody = JsonConvert.DeserializeObject<XpLeaderboard.Root>(responseBody);
            return Ok(usersResponseBody);
        }


        [HttpGet("/news")]
        public async Task<ActionResult<string>> GetNews()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/news");
            string responseBody = await response.Content.ReadAsStringAsync();
            News.Root usersResponseBody = JsonConvert.DeserializeObject<News.Root>(responseBody);
            return Ok(usersResponseBody);
        }

    }
}