using FitnessTestApp.Models;
using FitnessTestApp.Services.Concrete;
using FitnessTestApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HomeViewModel _homeViewModel;
        private FitnessScoreService _fitnessScore;
        private AthleteService _athletes;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _fitnessScore = new FitnessScoreService();
            _athletes = new AthleteService();
            _homeViewModel = new HomeViewModel();
        }

        public IActionResult Index()
        {
            _homeViewModel.FitnessScore = _fitnessScore.GetAll();
            _homeViewModel.Athletes = _athletes.GetAll();

            _logger.LogInformation("Inside index");

            return View(_homeViewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id, int level, int shuttleLevel)
        {
            _logger.LogInformation("Inside edit action");

            Athlete athlete = _athletes.Get(id);
            return View(athlete);
        }

        public IActionResult Detail(string query)
        {
            _logger.LogInformation("Inside detail action");

            _athletes.updateProgress(query);
            var athletes = _athletes.GetAll();
            return View(athletes);
        }

        public IActionResult Details()
        {
            var athletes = _athletes.GetAll();
            return View(athletes);
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
    }
}
