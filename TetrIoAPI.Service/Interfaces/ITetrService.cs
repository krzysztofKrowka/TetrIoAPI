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
        Task<ServerActivityDTO.Root> GetActivity();
        Task<LeagueLeaderboardDTO.Root> GetLeagueLeaderboard();
        Task<NewsDTO.Root> GetNews();
        Task<ServerStatisticDTO.Root> GetStats();
        Task<UserInfoDTO.Root> GetUser(string user);
        Task<UserSearchDTO.Root> GetUserByDiscord(string query);
        Task<UserRecordsDTO.Root> GetUserRecords(string user);
        Task<XpLeaderboardDTO.Root> GetXpLeaderboard();
    }
}
