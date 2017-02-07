using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntegrationProject.Models;
using IntegrationProject.ViewModels;
using Microsoft.AspNet.Identity;

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

        // GET: Update Interests
        public ActionResult UpdateInterests()
        {
            var currentUserId = User.Identity.GetUserId();
            var interestInDatabase = _context.Interest.SingleOrDefault(m => m.UserId == currentUserId);
            UpdateInterestsViewModel viewModel = new UpdateInterestsViewModel()
            {
                UserId = currentUserId,
                Comedy = interestInDatabase.Comedy,
                Concerts = interestInDatabase.Concerts,
                Conferences = interestInDatabase.Conferences,
                Education = interestInDatabase.Education,
                Family = interestInDatabase.Family,
                Festivals = interestInDatabase.Festivals,
                Film = interestInDatabase.Film,
                Food = interestInDatabase.Food,
                Fundraisers = interestInDatabase.Fundraisers,
                Galleries = interestInDatabase.Galleries,
                Health = interestInDatabase.Health,
                Holidays = interestInDatabase.Holidays,
                Literary = interestInDatabase.Literary,
                Musuems = interestInDatabase.Musuems,
                Neighboorhood = interestInDatabase.Neighboorhood,
                NightLife = interestInDatabase.NightLife,
                OnCampus = interestInDatabase.OnCampus,
                Organizations = interestInDatabase.Organizations,
                Outdoors = interestInDatabase.Outdoors,
                Pets = interestInDatabase.Pets,
                PerformingArts = interestInDatabase.PerformingArts,
                Politics = interestInDatabase.Politics,
                Sales = interestInDatabase.Sales,
                Science = interestInDatabase.Science,
                Spiritualality = interestInDatabase.Spiritualality,
                Sports = interestInDatabase.Sports,
                Technology = interestInDatabase.Technology
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateInterests(UpdateInterestsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            else
            {
                var currentUserId = User.Identity.GetUserId();
                var interestInDatabase = _context.Interest.SingleOrDefault(m => m.UserId == currentUserId);

                interestInDatabase.Comedy = model.Comedy;
                interestInDatabase.Concerts = model.Concerts;
                interestInDatabase.Conferences = model.Conferences;
                interestInDatabase.Education = model.Education;
                interestInDatabase.Family = model.Family;
                interestInDatabase.Festivals = model.Festivals;
                interestInDatabase.Film = model.Film;
                interestInDatabase.Food = model.Food;
                interestInDatabase.Fundraisers = model.Fundraisers;
                interestInDatabase.Galleries = model.Galleries;
                interestInDatabase.Health = model.Health;
                interestInDatabase.Holidays = model.Holidays;
                interestInDatabase.Literary = model.Literary;
                interestInDatabase.Musuems = model.Musuems;
                interestInDatabase.Neighboorhood = model.Neighboorhood;
                interestInDatabase.NightLife = model.NightLife;
                interestInDatabase.OnCampus = model.OnCampus;
                interestInDatabase.Organizations = model.Organizations;
                interestInDatabase.Outdoors = model.Outdoors;
                interestInDatabase.Pets = model.Pets;
                interestInDatabase.PerformingArts = model.PerformingArts;
                interestInDatabase.Politics = model.Politics;
                interestInDatabase.Sales = model.Sales;
                interestInDatabase.Science = model.Science;
                interestInDatabase.Spiritualality = model.Spiritualality;
                interestInDatabase.Sports = model.Sports;
                interestInDatabase.Technology = model.Technology;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "DashBoard");
        }
    }
}