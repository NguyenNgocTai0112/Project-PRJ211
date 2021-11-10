using Microsoft.AspNetCore.Mvc;
using OnlineJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult DisplayAllAccount()
        {
            AccountList pst = new AccountList();
            List<Account> obj = pst.getAccount(string.Empty);
            return View(obj);
        }


        public IActionResult ListUser()
        {
            AccountUserList pst = new AccountUserList();
            List<AccountUser> obj = pst.getAccountUser(string.Empty);
            return View(obj);
        }


        public IActionResult ListEmployee()
        {
            AccountEmployerList pst = new AccountEmployerList();
            List<AccountEmployer> obj = pst.getAccountEmployee(string.Empty);
            return View(obj);
        }




        public IActionResult AllCV()
        {

            CVList pst = new CVList();
            List<CV> obj = pst.getCV(string.Empty);
            return View(obj);
        }

        public IActionResult AllPosting()
        {
            Posting2List pst = new Posting2List();
            List<Posting2> obj = pst.getPosting2(string.Empty);
            return View(obj);
        }


    }
}
