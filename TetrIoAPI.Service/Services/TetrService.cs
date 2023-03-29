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




        public async Task<ServerStatisticDTO.Root> GetStats()
        {
            var response = await client.GetAsync($"{link}/general/stats");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<ServerStatistic.Root>(responseBody);
            var statsDTO = new ServerStatisticDTO.Root()
            {
                Data = new ServerStatisticDTO.Data()
                {
                    UserCount = u.data.usercount,
                    AnonCount = u.data.anoncount,
                    RankedCount = u.data.rankedcount,
                    GamesPlayed = u.data.gamesplayed,
                    GamesFinished = u.data.gamesfinished
                },
            };
            return statsDTO;
        }




        public async Task<ServerActivityDTO.Root> GetActivity()
        {
            var response = await client.GetAsync($"{link}/general/activity");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<ServerActivity.Root>(responseBody);
            var activityDTO = new ServerActivityDTO.Root()
            {
                Data = new ServerActivityDTO.Data()
                {
                    Activity = u.data.activity,
                },
                Error = u.error
            };
            return activityDTO;
        }


        public async Task<UserInfoDTO.Root> GetUser(string user)
        {
            var response = await client.GetAsync($"{link}/users/{user}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<UserInfo.Root>(responseBody);
            var userDTO = new UserInfoDTO.Root()
            {
                Data = new UserInfoDTO.Data()
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
                },
                Error = u.error
            };
            return userDTO;
        }



        public async Task<UserRecordsDTO.Root> GetUserRecords(string user)
        {
            var response = await client.GetAsync($"{link}/users/{user}/records");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<UserRecords.Root>(responseBody);
            var userDTO = new UserRecordsDTO.Root()
            {
                Error = u.error,
                Data = new UserRecordsDTO.Data()
                {
                    Zen = u.data.zen,
                    Records = new UserRecordsDTO.Records()
                    {
                        _40l = new UserRecordsDTO._40l(),
                        Blitz = new UserRecordsDTO.Blitz()
                    }
                }
            };
            if(u.data.records._40l !=null)
            {
                userDTO.Data.Records._40l = new UserRecordsDTO._40l()
                {
                    Rank = u.data.records._40l.rank,
                };
                if(u.data.records._40l.record != null)
                {
                    userDTO.Data.Records._40l.Record = new UserRecordsDTO.Record()
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
                userDTO.Data.Records.Blitz = new UserRecordsDTO.Blitz()
                {
                    Rank = u.data.records.blitz.rank
                };
                if (u.data.records.blitz.record != null)
                {
                    userDTO.Data.Records.Blitz.Record = new UserRecordsDTO.Record()
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



        public async Task<UserSearchDTO.Root> GetUserByDiscord(string query)
        {
            var response = await client.GetAsync($"{link}/users/search/{query}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<UserSearch.Root>(responseBody);
            var userDTO = new UserSearchDTO.Root()
            {
                Error = u.error,
                Data = u.data
            };
            return userDTO;
        }



        public async Task<LeagueLeaderboardDTO.Root> GetLeagueLeaderboard()
        {
            var response = await client.GetAsync($"{link}/users/lists/league");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<LeagueLeaderboard.Root>(responseBody);
            var leagueDTO = new LeagueLeaderboardDTO.Root()
            { 
                Error = u.error,
                Data = u.data
            };
            return leagueDTO;
        }


        public async Task<XpLeaderboardDTO.Root> GetXpLeaderboard()
        {
            var response = await client.GetAsync($"{link}/users/lists/xp");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<XpLeaderboard.Root>(responseBody);
            var xpDTO = new XpLeaderboardDTO.Root() 
            {
                Error = u.error,
                Data = u.data
            };
            return xpDTO;
        }


        public async Task<NewsDTO.Root> GetNews()
        {
            var response = await client.GetAsync($"{link}/news");
            var responseBody = await response.Content.ReadAsStringAsync();
            var u = JsonConvert.DeserializeObject<News.Root>(responseBody);
            var newsDTO = new NewsDTO.Root() 
            { 
                Error = u.error,
                Data = u.data
            };
            return newsDTO;
        }

    }
}
