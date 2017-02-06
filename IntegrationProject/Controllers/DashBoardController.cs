using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntegrationProject.Models;
using IntegrationProject.ViewModels;

namespace IntegrationProject.Controllers
{
    public class DashBoardController : Controller
    {
        private ApplicationDbContext _context;

        public DashBoardController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }

        // GET: UpdateAccount
        public ActionResult UpdateAccount()
        {
            var currentUserName = User.Identity.Name;
            var days = _context.Day.ToList();
            var months = _context.Months.ToList();
            var years = _context.Year.ToList();
            var currentUser = _context.Users.FirstOrDefault(m => m.UserName == currentUserName);

            var viewModel = new UpdateAccountViewModels()
            {
                FirstName = currentUser.FirstName,
                LastName = currentUser.LastName,
                DayId = currentUser.DayId,
                MonthId = currentUser.MonthId,
                YearId = currentUser.YearId,
                PhoneNumber = currentUser.PhoneNumber,
                ZipCode = currentUser.ZipCode,
                DaysList = days,
                MonthsList = months,
                YearsList = years
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateAccount(UpdateAccountViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            else
            {
                var currentUserName = User.Identity.Name;
                var userInDatabase = _context.Users.SingleOrDefault(m => m.UserName == currentUserName);

                userInDatabase.FirstName = model.FirstName;
                userInDatabase.LastName = model.LastName;
                userInDatabase.DayId = model.DayId;
                userInDatabase.MonthId = model.MonthId;
                userInDatabase.YearId = model.YearId;
                userInDatabase.PhoneNumber = model.PhoneNumber;
                userInDatabase.ZipCode = model.ZipCode;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "DashBoard");
        }
    }
}