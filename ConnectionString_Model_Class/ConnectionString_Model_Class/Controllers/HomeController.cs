using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConnectionString_Model_Class.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConnectionString_Model_Class.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<MailConfig> _config;

        public HomeController(ILogger<HomeController> logger, IOptions<MailConfig> config)
        {
            _logger = logger;
            _config = config;
        }
        public IActionResult Index()
        {
            string Email = _config.Value.mailFrom;
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
    }
}
