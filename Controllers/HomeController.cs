using LabNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ListResponseModel> listResponse = new List<ListResponseModel>()
            {
                new ListResponseModel
                {
                    Name = "Nguyen Van A",
                    Email = "mail@mail.com",
                    Phone = "012345678",
                    WillAttend = true
                },
                new ListResponseModel
                {
                    Name = "Nguyen Van B",
                    Email = "mail2@mail.com",
                    Phone = "012345679",
                    WillAttend = false
                },
                new ListResponseModel
                {
                    Name = "Nguyen Van C",
                    Email = "mail3@mail.com",
                    Phone = "012345677",
                    WillAttend = true
                },
            };
            ViewBag.List = listResponse;
            ViewData["list"] = listResponse;

            return View(listResponse);
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