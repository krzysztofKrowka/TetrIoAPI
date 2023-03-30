using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrIoAPI.Service.DTOs;

namespace TetrIoAPI.Service.Interfaces
{

    public interface ITetrService
    {
        Task<ServerActivityDTO.Data> GetActivity();
        Task<LeagueLeaderboardDTO.Data> GetLeagueLeaderboard(int pageNumber,int pageSize);
        Task<NewsDTO.Data> GetNews(int pageNumber, int pageSize);
        Task<ServerStatisticDTO.Data> GetStats();
        Task<UserInfoDTO.Data> GetUser(string user);
        Task<UserSearchDTO.Data> GetUserByDiscord(string query);
        Task<UserRecordsDTO.Data> GetUserRecords(string user);
        Task<XpLeaderboardDTO.Data> GetXpLeaderboard(int pageNumber, int pageSize);
    }
}
