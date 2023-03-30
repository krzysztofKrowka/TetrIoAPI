using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TetrIoAPI.Service.Interfaces;
using TetrIoAPI.Service.Models;
using TetrIoAPI.Service.Services;

namespace TetrIoAPI.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TetrController : ControllerBase
    {
        private HttpClient client = new HttpClient();
        private string link = "https://ch.tetr.io/api";

        private readonly ITetrService _service;

        public TetrController(ITetrService service)
        {
            _service = service;
        }





        [HttpGet("/general/stats")]
        public async Task<ActionResult> GetStats()
        {
            var statsResponseBody = await _service.GetStats();
            return Ok(statsResponseBody);
        }



        [HttpGet("/general/activity")]
        public async Task<ActionResult> GetActivity()
        {
            var activityResponseBody = await _service.GetActivity();
            return Ok(activityResponseBody);
        }

        
        [HttpGet("/users/{user}")]
        public async Task<ActionResult> GetUser(string user)
        {
            var userResponseBody = await _service.GetUser(user);
            return Ok(userResponseBody);
        }



        [HttpGet("/users/{user}/records")]
        public async Task<ActionResult> GetUserRecords(string user)
        {
            var userResponseBody = await _service.GetUserRecords(user);
            return Ok(userResponseBody);
        }



        [HttpGet("/users/search/{query}")]
        public async Task<ActionResult> GetUserByDiscord(string query)
        {
            var userResponseBody = await _service.GetUserByDiscord(query);
            return Ok(userResponseBody);
        }



        [HttpGet("/users/lists/league")]
        public async Task<ActionResult> GetLeagueLeaderboard(int pageNumber, int pageSize)
        {
            var usersResponseBody = await _service.GetLeagueLeaderboard(pageNumber,pageSize);
            return Ok(usersResponseBody);
        }



        [HttpGet("/users/lists/xp")]
        public async Task<ActionResult> GetXpLeaderboard(int pageNumber, int pageSize)
        {
            var usersResponseBody = await _service.GetXpLeaderboard(pageNumber, pageSize);
            return Ok(usersResponseBody);
        }


        [HttpGet("/news")]
        public async Task<ActionResult> GetNews(int pageNumber, int pageSize)
        {
            var newsResponseBody = await _service.GetNews( pageNumber, pageSize);
            return Ok(newsResponseBody);
        }

    }
}