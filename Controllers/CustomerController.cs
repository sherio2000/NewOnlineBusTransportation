using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBusTransportation.Data;
using OnlineBusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Controllers
{
    [Authorize(Roles = "User")]

    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomerController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }


        public async Task<IActionResult> Search()
        {
            ViewData["Departure"] = new SelectList(_context.Departure, "ID", "Name");
            ViewData["Destination"] = new SelectList(_context.Destination, "ID", "Name");

            return View();
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


                DateTime journeydate = Convert.ToDateTime(form["datepicker"]);

                results = await (from businfo in _context.BusInfo
                                 join buses in _context.Buses on businfo.BusID equals buses.ID
                                 select new BusInfoViewModel()
                                 {
                                     ID = businfo.ID,

                                     BusID = buses.ID,
                                     BusNumber = buses.BusNumber,
                                     Name = buses.Name,
                                     Destination = businfo.Destination,
                                     Departure = businfo.Departure,
                                     datetime = businfo.datetime,
                                     AvailableSeats = businfo.availableSeats,
                                     BookedSeats = businfo.BookedSeats
                                 }).Where(b => b.Departure == departure.Name.ToString() && b.Destination == destination.Name.ToString() && b.datetime == journeydate).ToListAsync();
            }
            else
            {
                results = await (from businfo in _context.BusInfo
                                 join buses in _context.Buses on businfo.BusID equals buses.ID
                                 select new BusInfoViewModel()
                                 {
                                     ID=businfo.ID,
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
        //book seat
        public async Task<IActionResult> BookSeat(int businfoid,int busid)
        {
            SeatBooking SB = new SeatBooking();

            var ItemsList1 = new List<Row1>();
            var ItemsList2 = new List<Row2>();
            var ItemsList3 = new List<Row3>();
            var ItemsList4 = new List<Row4>();
            var ItemsList5 = new List<Row5>();
            string bookingseats = "";
            var seat = _context.UsersBooking.Where(b => b.BusInfoID == businfoid).ToList();
            List<int> seatsIds = new List<int>();
            if (seat.Count > 0)
            {


                foreach (var item in seat)
                {
                    bookingseats += item.Seats + ",";
                }
                bookingseats = bookingseats.Replace(",,", ",");
                if (bookingseats.StartsWith(","))
                {
                    bookingseats = bookingseats.TrimStart(',');

                }
                if (bookingseats.EndsWith(","))
                {
                    bookingseats = bookingseats.TrimEnd(',');

                }
                seatsIds = bookingseats.Split(',').Select(int.Parse).ToList();
                seatsIds.Add(00);
                seatsIds.Add(2);
                seatsIds.Add(4);
                seatsIds.Add(7);
                seatsIds.Add(9);
                seatsIds.Add(12);
                seatsIds.Add(14);
                seatsIds.Add(17);
                seatsIds.Add(19);
                seatsIds.Add(22);
                seatsIds.Add(24);


            }
            else
            {
                seatsIds.Add(00);
                seatsIds.Add(2);
                seatsIds.Add(4);
                seatsIds.Add(7);
                seatsIds.Add(9);
                seatsIds.Add(12);
                seatsIds.Add(14);
                seatsIds.Add(17);
                seatsIds.Add(19);
                seatsIds.Add(22);
                seatsIds.Add(24);


            }

            for (int i = 1; i <= 5; i++)
            {
                if (seatsIds.Contains(i))
                {
                    ItemsList1.Add(new Row1 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "seatUnavailable" });

                }
                else
                {
                    ItemsList1.Add(new Row1 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "" });

                }

            }
            for (int i = 6; i <= 10; i++)
            {
                if (seatsIds.Contains(i))
                {
                    ItemsList2.Add(new Row2 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "seatUnavailable" });

                }
                else
                {
                    ItemsList2.Add(new Row2 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "" });

                }

                // ItemsList2.Add(new Row2 { SeatID = "2_" + i, SeatNumber = i, SeatStatus = "" });
            }
            for (int i = 11; i <= 15; i++)
            {
                if (seatsIds.Contains(i))
                {
                    ItemsList3.Add(new Row3 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "seatUnavailable" });

                }
                else
                {
                    ItemsList3.Add(new Row3 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "" });

                }

                //ItemsList3.Add(new Row3 { SeatID = "3_" + i, SeatNumber = i, SeatStatus = "" });
            }
            for (int i = 16; i <= 20; i++)
            {
                if (seatsIds.Contains(i))
                {
                    ItemsList4.Add(new Row4 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "seatUnavailable" });

                }
                else
                {
                    ItemsList4.Add(new Row4 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "" });

                }

                // ItemsList4.Add(new Row4 { SeatID = "4_" + i, SeatNumber = i, SeatStatus = "" });
            }
            for (int i = 21; i <= 25; i++)
            {
                if (seatsIds.Contains(i))
                {
                    ItemsList5.Add(new Row5 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "seatUnavailable" });

                }
                else
                {
                    ItemsList5.Add(new Row5 { SeatID = "1_" + i, SeatNumber = i, SeatStatus = "" });

                }

                //ItemsList5.Add(new Row5 { SeatID = "5_" + i, SeatNumber = i, SeatStatus = "" });
            }
            SB.Row1 = ItemsList1;
            SB.Row2 = ItemsList2;
            SB.Row3 = ItemsList3;
            SB.Row4 = ItemsList4;
            SB.Row5 = ItemsList5;
            var businfo = _context.BusInfo.Where(b => b.ID == businfoid).FirstOrDefault();
            var bus = _context.Buses.Where(b => b.ID == busid).FirstOrDefault();

            TempData["Name"] = bus.Name;
            TempData["BusNumber"] = bus.BusNumber;
            TempData["Departure"] = businfo.Departure;
            TempData["Destination"] = businfo.Destination;
            TempData["DepartureTime"] = businfo.datetime;
            TempData["BusInfoID"] = businfo.ID;

            return View(SB);
        }
        //show confirm booking message
        public async Task<IActionResult> ConfirmBooking()
        {
            return View();
        }
            [HttpPost]
        public async Task<IActionResult> ConfirmBooking(IFormCollection form,SeatBooking model)
        {
            UsersBooking userbooking = new UsersBooking();
            int businfoid =Convert.ToInt32(form["businfoid"]);
            var price = Convert.ToInt32(form["price"]);
            var Item = new List<KeyValuePair<string, string>>();

            foreach (var key in form.Keys)
            {

                Item.Add(new KeyValuePair<string, string>(key, form[key]));

            }
            Item.RemoveAt(Item.Count - 1);
            Item.RemoveAt(0);
            Item.RemoveAt(1);

            string seats = "";
            foreach (var element in Item)
            {
                seats += element.Value+",";
            }
            string seatslist = seats.Remove(seats.Length - 1, 1);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            userbooking.Seats = seatslist;
            userbooking.BusInfoID = businfoid;
            userbooking.UserID = userId;
            userbooking.price = price;
           _context.UsersBooking.Add(userbooking);
           // _context.SaveChanges();
            var businfoupdate = _context.BusInfo.AsNoTracking().Where(b => b.ID == businfoid).FirstOrDefault();
            //  var bookinginfo = _context.userb.AsNoTracking().Where(b => b.ID == businfoid).FirstOrDefault();            Item.RemoveAt(0);
            Item.RemoveAt(0);
            int avbseats = businfoupdate.availableSeats;
            int bookedseats = Item.Count();
            int updatedseats = avbseats - bookedseats;
            var businfo = new BusInfo() { ID = businfoid, availableSeats= updatedseats,BookedSeats=bookedseats+ businfoupdate.BookedSeats };
            _context.BusInfo.Attach(businfo);
            _context.Entry(businfo).Property(x => x.availableSeats).IsModified = true;
            _context.Entry(businfo).Property(x => x.BookedSeats).IsModified = true;

            _context.SaveChanges();


            return View();
        }
        public async Task<IActionResult> ShowBooking(int businfoid)
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
                                 }).Where(b => b.userid== userId && b.BusInfoID==businfoid).ToListAsync();
           
            return View(results);
        }
        public async Task<IActionResult> CancelBooking(int bookingid,int businfoid)
        {
            var userbooking = new UsersBooking { BookingID = bookingid };
            _context.UsersBooking.Attach(userbooking);
            _context.UsersBooking.Remove(userbooking);
            var bookingdata = _context.UsersBooking.AsNoTracking().Where(b => b.BookingID == bookingid).FirstOrDefault();
            string bookedSeats = bookingdata.Seats .Substring(1);
            int bookedseats = bookedSeats.Split(',').Length;
            var businfodata = _context.BusInfo.AsNoTracking().Where(b => b.ID == businfoid).FirstOrDefault();
            int availableseats = businfodata.availableSeats;
            int bookedseats1 = businfodata.BookedSeats;
            int updatedavailableseats = availableseats + bookedseats;
            int updatedbookedseats = bookedseats1 - bookedseats;

            
            var businfo = new BusInfo() { ID = businfoid, availableSeats = updatedavailableseats, BookedSeats = updatedbookedseats };
            _context.BusInfo.Attach(businfo);
            _context.Entry(businfo).Property(x => x.availableSeats).IsModified = true;
            _context.Entry(businfo).Property(x => x.BookedSeats).IsModified = true;

            _context.SaveChanges();



            return RedirectToAction("ShowBooking", new { businfoid = businfoid });
        }

        public async Task<IActionResult> Feedback(string id)
        {
            if (!string.IsNullOrEmpty(id))
           {
                TableManager TableManagerObj = new TableManager("UsersFeedback"); // 'person' is the name of the table  
                                                                           // pass query where RowKey eq value of id
                List<UsersFeedback> usersListObj = TableManagerObj.RetrieveEntity<UsersFeedback>("RowKey eq '" + id + "'");
                UsersFeedback userObj = usersListObj.FirstOrDefault();

                return View(userObj);
            }

            ViewBag.company = new SelectList(_context.Users.Where(u=>u.userrole=="Staff"), "Id", "Email");

            return View(new UsersFeedback());
                   }
        [HttpPost]
        public async Task<IActionResult> SubmitFeedback(string id,UsersFeedback UF,IFormCollection form)
        {
           // UsersFeedback UsersObj = new UsersFeedback();

            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            UF.CreatedBy = applicationUser.Id;
            UF.CreatedDate = DateTime.Now;
            string staffid = form["company"];
            UF.CompanyID = staffid;
          //  var staff = _context.Users.Where(d => d.Id == staffid).FirstOrDefault();

            if (ModelState.IsValid)
            {
                // Insert  
                if (string.IsNullOrEmpty(id))
                {
                    UF.PartitionKey = "User";
                    UF.RowKey = Guid.NewGuid().ToString();
                    TableManager TableManagerObj = new TableManager("UsersFeedback");
                    TableManagerObj.InsertEntity<UsersFeedback>(UF, true);
                }
                TempData["Message"] = "Done";

                return RedirectToAction("Feedback");
            }
            return View();
        }


    }
}
