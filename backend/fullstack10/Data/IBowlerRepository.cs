using fullstack10.Models;

namespace fullstack10.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<object> GetAllBowlersWithTeamsSharksMarlins();
    }
}
