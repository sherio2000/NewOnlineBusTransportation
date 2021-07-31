using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBusTransportation.Data;
using OnlineBusTransportation.Models;

namespace OnlineBusTransportation.Controllers
{
    [Authorize(Roles = "Staff")]
    public class BusesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BusesController(UserManager<ApplicationUser> userManager,ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        //show seats information
        
              public async Task<IActionResult> ShowBookedSeats(int? id)
        {
            var buses = await _context.Buses
                  .FirstOrDefaultAsync(m => m.ID == id);
            TempData["Name"] = buses.Name;
            TempData["BusNumber"] = buses.BusNumber;
            TempData["ID"] = buses.ID;


            return View(await _context.BusInfo.Where(B => B.BusID == id).ToListAsync());
        }
        //show all booking money received
        public async Task<IActionResult> ShowAllBooking(int businfoid)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId

            ShowBookingViewModel SB = new ShowBookingViewModel();
            var results = await (from businfo in _context.BusInfo
                                 join booking in _context.UsersBooking on businfo.ID equals booking.BusInfoID
                                 join bus in _context.Buses on businfo.BusID equals bus.ID

                                 select new ShowBookingViewModel()
                                 {
                                     userid = booking.UserID,
                                     BookingID = booking.BookingID,
                                     BusInfoID = booking.BusInfoID,
                                     BusNumber = bus.BusNumber,
                                     Name = bus.Name,
                                     Destination = businfo.Destination,
                                     Departure = businfo.Departure,
                                     datetime = businfo.datetime,
                                     Seats = booking.Seats,
                                     price = booking.price
                                 }).Where(b => b.BusInfoID == businfoid).ToListAsync();

            return View(results);
        }

        //show buses routes

        public async Task<IActionResult> ShowRoutes(int? id)
        {
            var buses = await _context.Buses
                  .FirstOrDefaultAsync(m => m.ID == id);
            TempData["Name"] = buses.Name;
            TempData["BusNumber"] = buses.BusNumber;
            TempData["ID"] = buses.ID;


            return View(await _context.BusInfo.Where(B => B.BusID == id).ToListAsync());
        }

        // GET: Buses
        public async Task<IActionResult> Index()
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            return View(await _context.Buses.Where(B=>B.CreatedBy==applicationUser.Id).ToListAsync());
        }
        //users feedback
        public async Task<IActionResult> ViewFeedback()
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            TableManager TableManagerObj = new TableManager("UsersFeedback");
            List<UsersFeedback> usersfeedbacklist =TableManagerObj.RetrieveEntity<UsersFeedback>();
            return View(usersfeedbacklist.Where(u=>u.CompanyID==applicationUser.Id).ToList());
        }


        //show seats
        public async Task<IActionResult> Seats()
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            return View(await _context.Buses.Where(B => B.CreatedBy == applicationUser.Id).ToListAsync());
        }

        // GET: Buses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buses = await _context.Buses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (buses == null)
            {
                return NotFound();
            }

            return View(buses);
        }

        // GET: Buses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Buses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Type,BusCapacity,BusNumber")] Buses buses)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            buses.CreatedBy = applicationUser.Id;
            buses.CreatedDate = DateTime.Now;
            
            if (ModelState.IsValid)
            {
                _context.Add(buses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(buses);
        }

        // GET: Buses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buses = await _context.Buses.FindAsync(id);
            if (buses == null)
            {
                return NotFound();
            }
            return View(buses);
        }

        // POST: Buses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Type,BusCapacity,BusNumber")] Buses buses)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            buses.CreatedBy = applicationUser.Id;
            buses.CreatedDate = DateTime.Now;

            if (id != buses.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusesExists(buses.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(buses);
        }

        // GET: Buses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buses = await _context.Buses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (buses == null)
            {
                return NotFound();
            }

            return View(buses);
        }

        // POST: Buses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buses = await _context.Buses.FindAsync(id);
            _context.Buses.Remove(buses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //add bus route information
        public async Task<IActionResult> AddRoute(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buses = await _context.Buses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (buses == null)
            {
                return NotFound();
            }
            ViewData["Departure"] = new SelectList(_context.Departure, "ID", "Name");
            ViewData["Destination"] = new SelectList(_context.Destination, "ID", "Name");

            return View(buses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoute(IFormCollection form)
        {
            int busid =Convert.ToInt32(form["ID"]);
            string departureid = form["Departure"];
            string destinationid = form["Destination"];
            var departure = _context.Departure.Where(d => d.ID ==Convert.ToInt32(departureid)).FirstOrDefault();
            var destination = _context.Destination.Where(d => d.ID == Convert.ToInt32(destinationid)).FirstOrDefault();

            DateTime date =Convert.ToDateTime(form["DepartureDate"]);
            var bus = _context.Buses.Where(b => b.ID == busid).FirstOrDefault();
            BusInfo b = new BusInfo();
            b.BusID = busid;
            b.Departure = departure.Name;
            b.Destination = destination.Name;
            b.datetime = date;
            b.availableSeats =40;
            b.BookedSeats = 0;
            _context.Add(b);
            await _context.SaveChangesAsync();
            return RedirectToAction("ShowRoutes", new { id = busid });
            
            //return View();
        }
        //Edit routes
        public async Task<IActionResult> EditRoute(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busesinfo = await _context.BusInfo.FindAsync(id);
            var bus = await _context.Buses.FirstOrDefaultAsync(m => m.ID == busesinfo.BusID);
            TempData["BusName"] = bus.Name;
            TempData["BusNumber"] = bus.BusNumber;
            var departureid = _context.Departure.Where(d => d.Name == busesinfo.Departure).FirstOrDefault();
            var destinationid = _context.Destination.Where(d => d.Name == busesinfo.Destination).FirstOrDefault();
           
            ViewBag.Departure = new SelectList(_context.Departure, "ID", "Name", departureid.ID);

            //ViewData["Departure"] = lis;
            ViewBag.Destination = new SelectList(_context.Destination, "ID", "Name", destinationid.ID);
            if (busesinfo == null)
            {
                return NotFound();
            }
            return View(busesinfo);
        }

        // POST: routes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRoute(int id, [Bind("ID,BusID,Departure,Destination,datetime")] BusInfo busesinfo,IFormCollection FORM)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            var busdata = _context.BusInfo.Where(B=>B.BusID==busesinfo.BusID).FirstOrDefault();
            string departureid = FORM["Departure"];
            string destinationid = FORM["Destination"];
            var departure = _context.Departure.Where(d => d.ID == Convert.ToInt32(departureid)).FirstOrDefault();
            var destination = _context.Destination.Where(d => d.ID == Convert.ToInt32(destinationid)).FirstOrDefault();

            busdata.Departure = departure.Name;
            busdata.Destination = destination.Name;
            busdata.datetime = busesinfo.datetime;
            _context.Entry(busdata).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            if (id != busesinfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(busesinfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusesExists(busesinfo.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ShowRoutes", new { id = busesinfo.BusID });
            }
            return View(busesinfo);
        }

        // GET: Buses/Delete/5
        public async Task<IActionResult> RouteDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buses = await _context.BusInfo
                .FirstOrDefaultAsync(m => m.ID == id);
            var bus=await _context.Buses.FirstOrDefaultAsync(m => m.ID == buses.BusID);
            TempData["BusName"] = bus.Name;
            TempData["BusNumber"] = bus.BusNumber;

            if (buses == null)
            {
                return NotFound();
            }

            return View(buses);
        }

        // POST: Buses/Delete/5
        [HttpPost, ActionName("RouteDeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RouteDeleteConfirmed(int id,int busid)
        {
            var buses = await _context.BusInfo.FindAsync(id);
            _context.BusInfo.Remove(buses);
            await _context.SaveChangesAsync();
            return RedirectToAction("ShowRoutes", new { id = busid });
        }
        private bool BusesExists(int id)
        {
            return _context.Buses.Any(e => e.ID == id);
        }
    }
}
