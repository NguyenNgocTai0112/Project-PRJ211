using Microsoft.AspNetCore.Mvc;
using OnlineJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OnlineJob.Models.ViewProfile;

namespace OnlineJob.Controllers
{
    public class ViewProfileController : Controller
    {
        public IActionResult Index()
        {
            ViewListProfile vlst = new ViewListProfile();
            List<ViewProfile> obj = vlst.GetProfile(string.Empty);
            return View(obj);
        }
    }
}
