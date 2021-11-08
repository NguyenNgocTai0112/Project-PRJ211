using Microsoft.AspNetCore.Mvc;
using OnlineJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Controllers
{
    public class PostingController : Controller
    {
        public IActionResult Index()
        {

            PostingList pst = new PostingList();
            List<Posting> obj = pst.getPosting(string.Empty);
            return View(obj);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Posting pst)
        {
            if (ModelState.IsValid)
            {
                PostingList pstList = new PostingList();
                pstList.AddPosting(pst);
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Details(string id = "")
        {
            PostingList pstList = new PostingList();
            List<Posting> obj = pstList.getPosting(id);
            return View(obj.FirstOrDefault());

        }
        public IActionResult Delete(string id = "")
        {
            PostingList pstList = new PostingList();
            List<Posting> obj = pstList.getPosting(id);
            return View(obj.FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Delete(Posting pst)
        {
            PostingList pstList = new PostingList();
            pstList.DeletePosting(pst);
            return RedirectToAction("Index");
        }





    }
}
