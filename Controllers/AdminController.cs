using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OnlineBusTransportation.Data;
using OnlineBusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserWithRole
    {
        public string UserName { get; set; } // You can alias the SQL output to give these better names
        public string Name { get; set; }
    }

    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        //update delete staff
        public IActionResult  GetAllStaff()
        {
            var userslist = _context.Users.Where(u => u.userrole == "Staff").ToList();
            List<StaffViewModel> staffList = new List<StaffViewModel>(); 


            foreach (var item in userslist)

            {

                StaffViewModel objcvm = new StaffViewModel(); // ViewModel

                objcvm.FirstName = item.FirstName;

                objcvm.LastName = item.LastName;

                objcvm.Phone = item.Phone;

                objcvm.Email = item.Email;
                objcvm.ID = item.Id;

                staffList.Add(objcvm);

            }
            return View(staffList);
        }

        public IActionResult CreateStaffID()
        {
            string msg = TempData["Message"] as string;
            if (!string.IsNullOrEmpty(msg))
            {
                TempData["Message"] = "done";
            }
            return View();
        }

        // POST: Staff/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStaffID(IFormCollection form)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            string firstname = form["firstname"];
            string lastname = form["lastname"];
            string email= form["email"];
            string phone = form["phone"];

            string password = form["password"];
            var userstaff = new ApplicationUser();
            userstaff.UserName = email;
            userstaff.Email = email;
            string userstaffPWD = password;
            userstaff.FirstName = firstname;
            userstaff.LastName = lastname;
            userstaff.Phone = phone;
            userstaff.userrole = "Staff";
            IdentityResult chkUserstaff = await _userManager.CreateAsync(userstaff, userstaffPWD);
            if (chkUserstaff.Succeeded)
            {
                var result = await _userManager.AddToRoleAsync(userstaff, "Staff");
                TempData["Message"] = "Done";
            }

            return View();
        }

        // GET: Buses/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
                StaffViewModel objcvm = new StaffViewModel(); // ViewModel

                objcvm.FirstName = users.FirstName;

                objcvm.LastName = users.LastName;

                objcvm.Phone = users.Phone;

                objcvm.Email = users.Email;
                objcvm.ID = users.Id;

                if (users == null)
            {
                return NotFound();
            }
            return View(objcvm);
        }

        // POST: Buses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, StaffViewModel staff)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            var user = await _userManager.FindByIdAsync(id);
            user.FirstName = staff.FirstName;
            user.LastName = staff.LastName;
            user.Phone = staff.Phone;
            user.Email = staff.Email;
            user.UserName = staff.Email;
            user.NormalizedEmail = staff.Email;
            user.NormalizedUserName = staff.Email;

            var result = await _userManager.UpdateAsync(user);
            if (id != staff.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction("GetAllStaff");
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var users = await _context.Users.FindAsync(id);
            StaffViewModel objcvm = new StaffViewModel(); // ViewModel

            objcvm.FirstName = users.FirstName;

            objcvm.LastName = users.LastName;

            objcvm.Phone = users.Phone;

            objcvm.Email = users.Email;
            objcvm.ID = users.Id;

            if (users == null)
            {
                return NotFound();
            }

            return View(objcvm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllStaff");
        }

        //users feedback
        public async Task<IActionResult> ViewFeedback()
        {
            TableManager TableManagerObj = new TableManager("UsersFeedback");
            List<UsersFeedback> usersfeedbacklist = TableManagerObj.RetrieveEntity<UsersFeedback>();
            return View(usersfeedbacklist);

        }
        public IActionResult GetAllUsers()
        {
            var userslist = _context.Users.Where(u => u.userrole == "User").ToList();
            List<StaffViewModel> staffList = new List<StaffViewModel>();


            foreach (var item in userslist)

            {

                StaffViewModel objcvm = new StaffViewModel(); // ViewModel

                objcvm.FirstName = item.FirstName;

                objcvm.LastName = item.LastName;

                objcvm.Phone = item.Phone;

                objcvm.Email = item.Email;
                objcvm.ID = item.Id;

                staffList.Add(objcvm);

            }
            return View(staffList);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
            StaffViewModel objcvm = new StaffViewModel(); // ViewModel

            objcvm.FirstName = users.FirstName;

            objcvm.LastName = users.LastName;

            objcvm.Phone = users.Phone;

            objcvm.Email = users.Email;

            objcvm.ID = users.Id;

            if (users == null)
            {
                return NotFound();
            }
            return View(objcvm);
        }

        // POST: Buses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(string id, StaffViewModel staff)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            var user = await _userManager.FindByIdAsync(id);
            user.FirstName = staff.FirstName;
            user.LastName = staff.LastName;
            user.Phone = staff.Phone;
            user.Email = staff.Email;
            user.UserName = staff.Email;
            user.NormalizedEmail = staff.Email;
            user.NormalizedUserName = staff.Email;
            var result = await _userManager.UpdateAsync(user);
            if (id != staff.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction("GetAllUsers");
            }
            return View();
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var users = await _context.Users.FindAsync(id);
            StaffViewModel objcvm = new StaffViewModel(); // ViewModel

            objcvm.FirstName = users.FirstName;

            objcvm.LastName = users.LastName;

            objcvm.Phone = users.Phone;

            objcvm.Email = users.Email;
            objcvm.ID = users.Id;

            if (users == null)
            {
                return NotFound();
            }

            return View(objcvm);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllUsers");
        }

        //users feedback
       
    }
}
