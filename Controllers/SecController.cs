using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RailTicket.Models;
using RailTicket.Models.Data;

namespace RailTicket.Controllers
{
    public class SecController : Controller
    {
        private readonly RailDbContext _context;

        public SecController(RailDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Logins()
        {
            //var logins = await _context.Logins.ToListAsync();
            return View();
        }
        public IActionResult Logins1(Login logins)
        {
            var pass = _context.User_Registrations.FirstOrDefault(x => x.Password == logins.Password);
            var Uname = _context.User_Registrations.FirstOrDefault(x => x.Email == logins.UserName);


            if ((pass != null && Uname != null) && (pass == Uname))
            {
                return RedirectToAction("TicketBookings", "Sec");
            }
            else
            {
                ModelState.AddModelError("", "invalid username or password");
                return View("Logins");

            }
        }



        [HttpGet]
        public IActionResult User_Registrations()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> User_Registrations1(User_Registration user_Registrations)
        {
            if (ModelState.IsValid)
            {
                _context.User_Registrations.Add(user_Registrations);
                await _context.SaveChangesAsync();
                return RedirectToAction("Logins", "Sec");
            }
            return View(User_Registrations);
        }

        //public  IActionResult Trains()
        //{
        //    var trains = _context.Trains.ToList();
        //    return Json(trains);
        //}

        [HttpGet]
        public IActionResult Train()
        {
            var trains = _context.Trains.ToList();
            return View(trains);
        }
        [HttpPost]
        public async Task<IActionResult> Trains1(Train Trains)
        {
            if (ModelState.IsValid)
            {
                _context.Trains.Add(Trains);
                await _context.SaveChangesAsync();
                return RedirectToAction("Passengers", "Sec");
            }
            return View(Trains);
        }


        [HttpGet]
        public async Task<IActionResult> TicketBookings()
        {
            //var ticketBookings = await _context.TicketBookings.ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TicketBookings1(TicketBooking TicketBookings)
        {
            if (ModelState.IsValid)
            {
                _context.TicketBookings.Add(TicketBookings);
                await _context.SaveChangesAsync();
                return RedirectToAction("Train", "Sec");
            }
            return View(TicketBookings);
            
        }

        [HttpGet]
        public async Task<IActionResult> Passengers()
        {
            //var passengers = await _context.Passengers.ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Passengers1(Passenger Passengers)
        {
            
                _context.Passengers.Add(Passengers);
                await _context.SaveChangesAsync();
                return RedirectToAction("payment", "Sec");
            
            
        }
        public IActionResult payment()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
