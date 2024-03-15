using fullstack10.Models;
using Microsoft.EntityFrameworkCore;

namespace fullstack10.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _bowlerContext;
        public EFBowlerRepository(BowlingLeagueContext temp) 
        { 
            _bowlerContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;

        public IEnumerable<object> GetAllBowlersWithTeamsSharksMarlins()
        {
            var bowlersWithTeams = _bowlerContext.Bowlers
            .Where(b => b.Team != null && (b.Team.TeamName == "Sharks" || b.Team.TeamName == "Marlins"))
            .Select(b => new
            {
                b.BowlerId,
                b.BowlerLastName,
                b.BowlerFirstName,
                b.BowlerMiddleInit,
                b.BowlerAddress,
                b.BowlerCity,
                b.BowlerState,
                b.BowlerZip,
                b.BowlerPhoneNumber,
                TeamName = b.Team != null ? b.Team.TeamName : null // Include the associated team name
            })
            .ToList();

            return bowlersWithTeams;
        }

    }
}
