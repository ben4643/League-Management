using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;

namespace ClassSchedule.Controllers
{
    public class MatchController : Controller
    {
        private Repository<Match> matches { get; set; }
        private Repository<Player> players { get; set; }
        private Repository<League> leagues { get; set; }

        public MatchController(MatchScheduleContext ctx)
        {
            matches = new Repository<Match>(ctx);
            players = new Repository<Player>(ctx);
            leagues = new Repository<League>(ctx);
        }

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public ViewResult Add()
        {
            this.LoadViewBag("Add");
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            this.LoadViewBag("Edit");
            var m = this.GetMatch(id);
            return View("Add", m);
        }

        [HttpPost]
        public IActionResult Add(Match m)
        {
            if (ModelState.IsValid) {
                if (m.MatchId == 0)
                    matches.Insert(m);
                else
                    matches.Update(m);
                matches.Save();
                return RedirectToAction("Index", "Home");
            }
            else {
                string operation = (m.MatchId == 0) ? "Add" : "Edit";
                this.LoadViewBag(operation);
                return View();
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var m = this.GetMatch(id);
            return View(m);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Match m)
        {
            matches.Delete(m);
            matches.Save();
            return RedirectToAction("Index", "Home");
        }

        // private helper methods
        private Match GetMatch(int id)
        {
            var classOptions = new QueryOptions<Match> {
                Where = m => m.MatchId == id
            };
            var list = matches.List(classOptions);

            // return first Class or blank Class if null
            return list.FirstOrDefault();
        }
        private void LoadViewBag(string operation)
        {
            ViewBag.Leagues = leagues.List(new QueryOptions<League> {
                OrderBy = l => l.LeagueId
            });
            ViewBag.Players = players.List(new QueryOptions<Player> {
                OrderBy = p => p.League
            });;
            ViewBag.Operation = operation;
        }
    }
}