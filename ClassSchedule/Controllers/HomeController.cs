using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;

namespace ClassSchedule.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Match> matches { get; set; }
        private Repository<League> leagues { get; set; }

        public HomeController(MatchScheduleContext ctx) {
            matches = new Repository<Match>(ctx);
            leagues = new Repository<League>(ctx);
        }

        public ViewResult Index(int id)
        {
            // options for League query
            var leagueOptions = new QueryOptions<League> { 
                OrderBy = l => l.LeagueId
            };

            // options for Matches query
            var matchOptions = new QueryOptions<Match>
            {
                OrderBy = m => m.MatchId
            };
            /*
            // order by League if no filter. Otherwise, filter by League and order by time.
            if (id == 0) {
                matchOptions.OrderBy = m => m.MatchId;
                matchOptions.ThenOrderBy = m => m.LeagueId;
            }
            else {
                matchOptions.Where = m => m.LeagueId == id;
                matchOptions.OrderBy = m => m.MilitaryTime;
            }
            */
            // execute queries
            ViewBag.Leagues = leagues.List(leagueOptions);
            var returnThing = matches.List(matchOptions);
            return View(returnThing);
        }
    }
}
