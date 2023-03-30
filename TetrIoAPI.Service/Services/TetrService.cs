using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrIoAPI.Service.Models;
using TetrIoAPI.Service.Interfaces;
using TetrIoAPI.Service.DTOs;

namespace TetrIoAPI.Service.Services
{
    

    public class TetrService : ITetrService
    {
        private HttpClient client = new HttpClient();
        private string link = "https://ch.tetr.io/api";
        //TODO
        //  Make leaderboards have input for how many users to get



        public async Task<ServerStatisticDTO.Data> GetStats()
        {
            var response = await client.GetAsync($"{link}/general/stats");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<ServerStatistic.Root>(responseBody);
            var statsDTO = new ServerStatisticDTO.Data()
            {
                    UserCount = u.data.usercount,
                    AnonCount = u.data.anoncount,
                    RankedCount = u.data.rankedcount,
                    GamesPlayed = u.data.gamesplayed,
                    GamesFinished = u.data.gamesfinished
            };
            return statsDTO;
        }

        public async Task<ServerActivityDTO.Data> GetActivity()
        {
            var response = await client.GetAsync($"{link}/general/activity");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<ServerActivity.Root>(responseBody);
            var activityDTO = new ServerActivityDTO.Data()
            {
                 Activity = u.data.activity,
            };
            return activityDTO;
        }

        public async Task<UserInfoDTO.Data> GetUser(string user)
        {
            var response = await client.GetAsync($"{link}/users/{user}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<UserInfo.Root>(responseBody);
            var userDTO = new UserInfoDTO.Data()
            {
                    User = new UserInfoDTO.User()
                    {
                        _Id = u.data.user._id,
                        Username = u.data.user.username,
                        Role = u.data.user.role,
                        Ts = u.data.user.ts,
                        Badges = u.data.user.badges,
                        Xp = u.data.user.xp,
                        GamesPlayed = u.data.user.gamesplayed,
                        GamesWon = u.data.user.gameswon,
                        Country = u.data.user.country,
                        BadStanding = u.data.user.badstanding,
                        SupporterTier = u.data.user.supporter_tier,
                        Verified = u.data.user.verified,
                        League = new UserInfoDTO.League()
                            {
                                GamesPlayed = u.data.user.league.gamesplayed,
                                GamesWon = u.data.user.league.gameswon,
                                Rating = u.data.user.league.rating,
                                Glicko = u.data.user.league.glicko,
                                Rd = u.data.user.league.rd,
                                Rank = u.data.user.league.rank,
                                BestRank = u.data.user.league.bestrank,
                                Apm = u.data.user.league.apm,
                                Pps = u.data.user.league.pps,
                                Vs = u.data.user.league.vs,
                                Decaying = u.data.user.league.decaying,
                                Standing = u.data.user.league.standing,
                                StandingLocal = u.data.user.league.standing_local,
                                PrevRank = u.data.user.league.prev_rank,
                                PrevAt = u.data.user.league.prev_at,
                                NextRank = u.data.user.league.next_rank,
                                NextAt = u.data.user.league.next_at,
                                Percentile = u.data.user.league.percentile,
                                PercentileRank = u.data.user.league.percentile_rank
                            },
                        AvatarRevision = u.data.user.avatar_revision,
                        BannerRevision = u.data.user.banner_revision,
                        Bio = u.data.user.bio,
                        FriendCount = u.data.user.friend_count,
                    }
            };
            return userDTO;
        }

        public async Task<UserRecordsDTO.Data> GetUserRecords(string user)
        {
            var response = await client.GetAsync($"{link}/users/{user}/records");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<UserRecords.Root>(responseBody);
            var userDTO = new UserRecordsDTO.Data()
            {
                    Zen = u.data.zen,
                    Records = new UserRecordsDTO.Records()
                    {
                        _40l = new UserRecordsDTO._40l(),
                        Blitz = new UserRecordsDTO.Blitz()
                    }
            };
            if(u.data.records._40l !=null)
            {
                userDTO.Records._40l = new UserRecordsDTO._40l()
                {
                    Rank = u.data.records._40l.rank,
                };
                if(u.data.records._40l.record != null)
                {
                    userDTO.Records._40l.Record = new UserRecordsDTO.Record()
                    {
                        _Id = u.data.records._40l.record._id,
                        Stream = u.data.records._40l.record.stream,
                        ReplayId = u.data.records._40l.record.replayid,
                        User = u.data.records._40l.record.user,
                        Ts = u.data.records._40l.record.ts
                    };
                }
                        
            }
            if(u.data.records.blitz != null)
            {
                userDTO.Records.Blitz = new UserRecordsDTO.Blitz()
                {
                    Rank = u.data.records.blitz.rank
                };
                if (u.data.records.blitz.record != null)
                {
                    userDTO.Records.Blitz.Record = new UserRecordsDTO.Record()
                    {
                        _Id = u.data.records.blitz.record._id,
                        Stream = u.data.records.blitz.record.stream,
                        ReplayId = u.data.records.blitz.record.replayid,
                        User = u.data.records.blitz.record.user,
                        Ts = u.data.records.blitz.record.ts
                    };
                }
            }
            return userDTO;
        }

        public async Task<UserSearchDTO.Data> GetUserByDiscord(string query)
        {
            var response = await client.GetAsync($"{link}/users/search/{query}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<UserSearch.Root>(responseBody);
            var userDTO = new UserSearchDTO.Data()
            {
                User = u.data
            };
            return userDTO;
        }

        public async Task<LeagueLeaderboardDTO.Data> GetLeagueLeaderboard(int pageNumber, int pageSize)
        {
            var response = await client.GetAsync($"{link}/users/lists/league?limit=100");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<LeagueLeaderboard.Root>(responseBody);
            var leagueDTO = new LeagueLeaderboardDTO.Data()
            { 
                Leaderboard = u.data
            };
            leagueDTO.Leaderboard.users= leagueDTO.Leaderboard.users.Skip((pageNumber-1)*pageSize).Take(pageSize);
            return leagueDTO;
        }

        public async Task<XpLeaderboardDTO.Data> GetXpLeaderboard(int pageNumber, int pageSize)
        {
            var response = await client.GetAsync($"{link}/users/lists/xp?limit=100");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<XpLeaderboard.Root>(responseBody);
            var xpDTO = new XpLeaderboardDTO.Data() 
            {
                Leaderboard = u.data
            };
            xpDTO.Leaderboard.users = xpDTO.Leaderboard.users.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return xpDTO;
        }

        public async Task<NewsDTO.Data> GetNews(int pageNumber, int pageSize)
        {
            var response = await client.GetAsync($"{link}/news?limit=100");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<News.Root>(responseBody);
            var newsDTO = new NewsDTO.Data() 
            { 
                News = u.data.news
            };
            newsDTO.News = newsDTO.News.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return newsDTO;
        }

    }
}
