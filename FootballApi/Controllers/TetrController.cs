using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TetrAPI;
using TetrAPI.Models;

namespace FootballApi.Controllers
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
            return Ok(responseBody);
        }



        [HttpGet("/general/activity")]
        public async Task<ActionResult<string>> GetActivity()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/general/activity");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }

        
        [HttpGet("/users/{user}")]
        public async Task<ActionResult<string>> GetUser(string user)
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/{user}");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
            //Root userResponseBody = JsonConvert.DeserializeObject<Root>(responseBody);
            //return Ok(userResponseBody);
        }



        [HttpGet("/users/{user}/records")]
        public async Task<ActionResult<string>> GetUserRecords(string user)
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/{user}/records");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }



        [HttpGet("/users/search/{query}")]
        public async Task<ActionResult<string>> GetUserByDiscord(string query)
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/search/{query}");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }



        [HttpGet("/users/lists/league")]
        public async Task<ActionResult<string>> GetLeagueLeaderboard()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/lists/league");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
            //List<Root> usersResponseBody = JsonConvert.DeserializeObject<List<Root>>(responseBody);
            //return Ok(usersResponseBody);
        }


        [HttpGet("/users/lists/league/all")]
        public async Task<ActionResult<string>> GetFullLeagueLeaderboard()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/lists/league/all");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }


        [HttpGet("/users/lists/xp")]
        public async Task<ActionResult<string>> GetXpLeaderboard()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/users/lists/xp");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }


        [HttpGet("/news")]
        public async Task<ActionResult<string>> GetNews()
        {
            HttpResponseMessage response = await client.GetAsync($"{link}/news");
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }

    }
}