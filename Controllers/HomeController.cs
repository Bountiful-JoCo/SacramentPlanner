using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SacramentPlanner.Models;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models.MeetingViewModels;

namespace SacramentPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly MeetingContext _context;

        public HomeController(MeetingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //About page. Do we need this?
       /* public async Task<ActionResult> About()
        {
            IQueryable<SpeechDateGroup> data =
                from speaker in _context.Speakers
                group speaker by speaker.SpeechDate into dateGroup
                select new SpeechDateGroup()
                {
                    SpeechDate = dateGroup.Key,
                    SpeakerCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }*/

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
