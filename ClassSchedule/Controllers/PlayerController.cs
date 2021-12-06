using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ClassSchedule.Controllers
{
    public class PlayerController : Controller
    {
        private Repository<Player> players { get; set; }
        public PlayerController(MatchScheduleContext ctx) => players = new Repository<Player>(ctx);

        public ViewResult Index()
        {
            var options = new QueryOptions<Player> {
                OrderBy = p => p.League
            };
            return View(players.List(options));
        }

        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(Player player)
        {
            if (ModelState.IsValid) {
                players.Insert(player);
                players.Save();
                return RedirectToAction("Index");
            }
            else{
                return View(player);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            return View(players.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Delete(Player player)
        {
            players.Delete(player);
            try
            {
                players.Save();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Unable to save - matches are played by this player");
                return RedirectToAction("Index");
            }
        }
    }
}