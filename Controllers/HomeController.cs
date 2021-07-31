using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnlineBusTransportation.Data;
using OnlineBusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(ApplicationDbContext context,RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;

        }

        public IActionResult Index()
        {
            ViewData["Departure"] = new SelectList(_context.Departure, "ID", "Name");
            ViewData["Destination"] = new SelectList(_context.Destination, "ID", "Name");

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

        //creating roles
        public async Task CreateRolesandUsers()
        {

            bool x = await _roleManager.RoleExistsAsync("Admin");
            if (!x)
            {
                // first we create Admin role   
                var role = new IdentityRole();
                role.Name = "Admin";
                await _roleManager.CreateAsync(role);
            }
            //Then we create a user 
            var user = new ApplicationUser();
            user.UserName = "Admin";
            user.Email = "admin@gmail.com";
            string userPWD = "Abc123!";
            //for user
            var customer = new ApplicationUser();
            customer.UserName = "customer1@gmail.com";
            customer.Email = "customer1@gmail.com";
            string customerPWD = "Abc123!";

            //for staff
            var userstaff = new ApplicationUser();
            userstaff.UserName = "Staff1@gmail.com";
            userstaff.Email = "Staff1@gmail.com";
            string userstaffPWD = "Abc123!";

            IdentityResult chkUser = await _userManager.CreateAsync(user, userPWD);
            IdentityResult chkUsercustomer = await _userManager.CreateAsync(customer, customerPWD);
            IdentityResult chkUserstaff = await _userManager.CreateAsync(userstaff, userstaffPWD);

            //Add default User to Role Admin    
            if (chkUser.Succeeded)
            {
                var result = await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (chkUsercustomer.Succeeded)
            {
                var result = await _userManager.AddToRoleAsync(customer, "User");
            }
            if (chkUserstaff.Succeeded)
            {
                var result = await _userManager.AddToRoleAsync(userstaff, "Staff");
            }
        }
}
}
