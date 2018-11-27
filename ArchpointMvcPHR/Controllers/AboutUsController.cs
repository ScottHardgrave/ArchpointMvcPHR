using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArchpointMvcPHR.Controllers
{
    [Microsoft.AspNetCore.Authorization.AllowAnonymous]
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}