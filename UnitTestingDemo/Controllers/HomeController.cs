using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Models;

namespace UnitTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetCountryName(int countryID)
        {
            string name;
            if (countryID == 1)
            {
                name = "India";
            }
            else if (countryID == 2)
            {
                name = "Germany";
            }
            else if (countryID == 3)
            {
                name = "France";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}
