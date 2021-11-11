using Microsoft.AspNetCore.Mvc;
using OnlineJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OnlineJob.Models.CV2;

namespace OnlineJob.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            CVList2 pst = new CVList2();
            List<CV2> obj = pst.getCV2(string.Empty);
            return View(obj);
        }
    }
}
