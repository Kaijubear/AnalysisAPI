using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnalysisAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnalysisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AnalysisController : ControllerBase
    {
        private readonly DailyOverviewContext _context;

        //constructor
        public AnalysisController(DailyOverviewContext context)
        {
            _context = context;

            if(_context.Overviews.Count() == 0)
            {
                //if collection is empty, create a temporary hold for today
                _context.Overviews.Add(new DailyOverview { Date = DateTime.Today });
                _context.SaveChanges();
            }
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
