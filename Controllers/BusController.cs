using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBusTransportation.Data;
using OnlineBusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Controllers
{
    public class BusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BusController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> SearchBuses()
        {
            return View();
        }
            [HttpPost]
        public async Task<IActionResult> SearchBuses(IFormCollection form)
        {
            string departureid = form["Departure"];
            string destinationid = form["destination"];
            var departure = _context.Departure.Where(d => d.ID == Convert.ToInt32(departureid)).FirstOrDefault();
            var destination = _context.Destination.Where(d => d.ID == Convert.ToInt32(destinationid)).FirstOrDefault();

            var date = form["datepicker"].ToString() as string;
            List<BusInfoViewModel> results = null; 
            if (!string.IsNullOrEmpty(date))
            {

            
            DateTime journeydate =Convert.ToDateTime(form["datepicker"]);

                results = await (from businfo in _context.BusInfo
                           join buses in _context.Buses on businfo.BusID equals buses.ID
                           select new BusInfoViewModel()
                           {
                               BusID=buses.ID,
                               BusNumber=buses.BusNumber,
                               Name=buses.Name,
                               Destination=businfo.Destination,
                               Departure=businfo.Departure,
                               datetime=businfo.datetime,
                               AvailableSeats=businfo.availableSeats,
                               BookedSeats=businfo.BookedSeats
                           }).Where(b => b.Departure == departure.Name.ToString() && b.Destination == destination.Name.ToString() && b.datetime == journeydate).ToListAsync();
            }
            else
            {
                results = await (from businfo in _context.BusInfo
                                     join buses in _context.Buses on businfo.BusID equals buses.ID
                                     select new BusInfoViewModel()
                                     {
                                         BusID = buses.ID,
                                         BusNumber = buses.BusNumber,
                                         Name = buses.Name,
                                         Destination = businfo.Destination,
                                         Departure = businfo.Departure,
                                         datetime = businfo.datetime,
                                         AvailableSeats = businfo.availableSeats,
                                         BookedSeats = businfo.BookedSeats
                                     }).Where(b => b.Departure == departure.Name.ToString() && b.Destination == destination.Name.ToString()).ToListAsync();

            }
            return View(results);
        }

    }
}
