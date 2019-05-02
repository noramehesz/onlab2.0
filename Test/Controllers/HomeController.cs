using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Models;


namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly GrillBerContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(GrillBerContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> MyHome()
        {
            return View(await _context.Grills.ToListAsync());
        }

       

        public async Task<IActionResult> _Reservations()
        {
            List<ReservationModel> _list = new List<ReservationModel>();
            string _userId = _userManager.GetUserId(HttpContext.User);
            foreach (var item in _context.Reservations)
            {
                if (item.UserId == _userId)
                {
                    ReservationModel _new = item;
                    _list.Add(_new);
                }
            }
            return View(_list);
        }

        [Route("CancelReservation")]
        [HttpPost]
        public async Task<IActionResult> CancelReservation(int res)
        {
            
            _context.Reservations.Remove(await _context.Reservations.FindAsync(res));
            _context.SaveChanges();
            return RedirectToAction("_Reservations");
        }

        public async Task<ActionResult> ReserveGrill(int? id)
        {

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("Unable to load this page. Please log in first");
            }
            else
            {
                if (id == null)
                {
                    return NotFound();
                }

                GrillModel grill = await _context.Grills.FindAsync(id);
                BigViewModel bvm = new BigViewModel
                {
                    grill = grill
                };

                if (grill == null)
                {
                    return NotFound();
                 } else

                return View(bvm);
            }
        }

        
        [HttpPost]
        public async Task<ActionResult> SaveReservation(ReservationViewModel res, GrillModel gri) {
            var user = await _userManager.GetUserAsync(User);

            ReservationModel resmod = new ReservationModel
            {
                PhoneNum = res.PhoneNum,
                ReservationDate = res.ReservationDate,
                ReservationComment = res.ReservationComment,
                UserId = user.Id,
                ReservGrills = new List<GrillReservation>(),
                ReservationAddress = res.ReservationAddress
            };

            Console.WriteLine(resmod.ReservationAddress + "nyenyenye");

            GrillReservation reservation = new GrillReservation
            {
                ReservationId = resmod.ReservationId,
                GrillId = gri.GrillId
            };

            resmod.ReservGrills.Add(reservation);

            _context.Reservations.Add(resmod);
            _context.SaveChanges();
            return RedirectToAction("_Reservations");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
