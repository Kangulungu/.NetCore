﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionString_Model_Class.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionString_Model_Class.Controllers
{
    public class MailController : Controller
    {
        private MailConfig _config;

        public MailController(MailConfig config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            string Email = _config.mailFrom;
            string hostName = _config.host;
            string password = _config.password;
            int portNo = _config.portNo;
            return View();
        }
    }
}