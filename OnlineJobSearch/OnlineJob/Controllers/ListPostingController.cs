using Microsoft.AspNetCore.Mvc;
using OnlineJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Controllers
{
    public class ListPostingController : Controller
    {
        public IActionResult Index()
        {
            PostingList pst = new PostingList();
            List<Posting> obj = pst.GetPosting(string.Empty);      
            return View(obj);
        }
    }
}
