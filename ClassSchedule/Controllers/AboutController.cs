using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ClassSchedule.Controllers
{
    public class AboutController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }
    }
}