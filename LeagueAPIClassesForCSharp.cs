using System.Collections.Generic;

namespace LeagueAPIForCSharp
{
    public class ChampionListDto
    {
        public IList<ChampionDto> champion { get; set;}
    }

    public class ChampionDto
    {
        public bool botMmEnabled { get; set; }
        public int defenseRank { get; set; }
        public int attackRank { get; set; }
        public int id { get; set; }
        public bool rankedPlayEnabled { get; set; }
        public string name { get; set; }
        public bool botEnabled { get; set; }
        public int difficultyRank { get; set; }
        public bool active { get; set; }
        public bool freeToPlay { get; set; }
        public int magicRank { get; set; }
    }

    public class RecentGamesDto
    {
        public IList<GameDto> games { get; set; }
        public long summonerId { get; set; }
    }

    public class GameDto
    {
        public int championId { get; set; }
        public long createDate { get; set; }
        public string createDateStr { get; set; }
        public IList<PlayerDto> fellowPlayers { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public bool invalid { get; set; }
        public int level { get; set; }
        public int mapId { get; set; }
        public int spell1 { get; set; }
        public int spell2 { get; set; }
        public IList<RawStatDto> statistics { get; set; }
        public string subType { get; set; }
        public int teamId { get; set; }
    }

    public class PlayerDto
    {
        public int championId { get; set; }
        public long summonerId { get; set; }
        public int teamid { get; set; }
    }

    public class RawStatDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int value { get; set; }
    }

    public class League
    {
        public IList<LeagueDto> leagues { get; set; }
    }

    public class LeagueDto
    {
        public IList<LeagueItemDto> entries { get; set; }
        public string name { get; set; }
        public string queue { get; set; }
        public string tier { get; set; }
        public long timestamp { get; set; }
    }

    public class LeagueItemDto
    {
        public bool isFreshBlood { get; set; }
        public bool isHotStreak { get; set; }
        public bool isInactive { get; set; }
        public bool isVeteran { get; set; }
        public long lastPlayed { get; set; }
        public string leagueName { get; set; }
        public int leaguePoints { get; set; }
        public int losses { get; set; }
        public MiniSeriesDto miniSeries { get; set; }
        public string playerOrTeamId { get; set; }
        public string playerOrTeamName { get; set; }
        public string queueType { get; set; }
        public string rank { get; set; }
        public string tier { get; set; }
        public long timeUnitDecay { get; set; }
        public int wins { get; set; }
    }

    public class MiniSeriesDto
    {
        public int losses { get; set; }
        public IList<characters> progress { get; set; }
        public int target { get; set; }
        public long tiemLeftToPlayMillis { get; set; }
        public int wins { get; set; }
    }

    public class characters
    {
        public string character { get; set; }
    }

    public class PlayerStatsSummaryListDto
    {
        public IList<PlayerStatsSummaryDto> playerStatSummaries { get; set; }
        public long summonerId { get; set; }
    }

    public class PlayerStatsSummaryDto
    {
        public IList<AggregatedStatDto> aggregatedStats { get; set; }
        public int losses { get; set; }
        public long modifyDate { get; set; }
        public string modifyDateStr { get; set; }
        public string playerStatSummaryType { get; set; }
        public int wins { get; set; }
    }

    public class AggregatedStatDto
    {
        public int count { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class RankedStatsDto
    {
        public IList<ChampionStatsDto> champions { get; set; }
        public long modifyDate { get; set; }
        public string modifyDateStr { get; set; }
        public long sommonerId { get; set; }
    }

    public class ChampionStatsDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<ChampionStatDto> stats { get; set; }
    }

    public class ChampionStatDto
    {
        public int count { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int value { get; set; }
    }

    public class MasteryPagesDto
    {
        public IList<MasteryPageDto> pages { get; set; }
        public long summonerId { get; set; }
    }
    
    public class MasteryPageDto
    {
        public bool current { get; set; }
        public string name { get; set; }
        public IList<TalentDto> talents { get; set; }
    }

    public class TalentDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int rank { get; set; }
    }

    public class RunePagesDto
    {
        public IList<RunePageDto> pages { get; set; }
        public long summonerId { get; set; }
    }

    public class RunePageDto
    {
        public bool current { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public IList<RuneSlotDto> slots { get; set; }
    }

    public class RuneSlotDto
    {
        public RuneDto rune { get; set; }
        public int runeSlotId { get; set; }
    }

    public class RuneDto
    {
        public string description { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int tier { get; set; }
    }

    public class SummonerDto
    {
        public long id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public string revisionDateStr { get; set; }
        public long summonerLevel { get; set; }
    }

    public class SummonerNameListDto
    {
        public IList<SummonerNameDto> summoners { get; set; }
    }

    public class SummonerNameDto
    {
        public long id { get; set; }
        public string name { get; set; }
    }
}