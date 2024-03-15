using fullstack10.Data;
using fullstack10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fullstack10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var bowlers = _bowlerRepository.Bowlers.ToArray();

            var bowlersWithTeams = _bowlerRepository.GetAllBowlersWithTeamsSharksMarlins();

            return bowlersWithTeams;
        }
    }
}
