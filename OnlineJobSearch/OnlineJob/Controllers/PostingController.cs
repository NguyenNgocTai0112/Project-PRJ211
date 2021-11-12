using Microsoft.AspNetCore.Mvc;
using OnlineJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OnlineJob.Controllers
{
    public class PostingController : Controller
    {
        public IActionResult Index(int ? page)
        {

            PostingList pst = new PostingList();
            List<Posting> obj = pst.GetPosting(string.Empty);         
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
        public IActionResult Details(string id)
        {
            PostingList pstList = new PostingList();
            List<Posting> obj = pstList.GetPosting(id);
            return View(obj.FirstOrDefault());

        }



        public IActionResult Delete(string id = "")
        {
            if (id.Equals(""))
            {
                return NotFound();
            }
            else
            {

                PostingList pstList = new PostingList();
                List<Posting> obj = pstList.GetPosting(id);
                return View(obj.FirstOrDefault());
            }
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {

            PostingList pstList = new PostingList();
            pstList.DeletePosting(id);
            return RedirectToAction("Index");
        }






        public IActionResult Edit(string id = "")
        {
            PostingList pstList = new PostingList();
            List<Posting> obj = pstList.GetPostingEdit(id);
            return View(obj.FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(Posting pst)
        {
            PostingList pstList = new PostingList();
            pstList.UpdatePosting(pst);
            return RedirectToAction("Index");

        }
        public IActionResult Job()
        {
            PostingList pst = new PostingList();
            List<Posting> obj = pst.GetPosting(string.Empty);
            return View(obj);
        }
    




    }

    
   
}
