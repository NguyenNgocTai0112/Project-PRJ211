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

        public IActionResult DeleteAccount(int id)
        {

            try
            {
            AccountList pstList = new AccountList();
            pstList.DeleteAccount(id);
            return RedirectToAction("DisplayAllAccount");
            }catch (Exception ex)
            {
                return RedirectToAction("Index");
            }



            
        }






        public IActionResult ListUser()
        {
            AccountUserList pst = new AccountUserList();
            List<AccountUser> obj = pst.getAccountUser(string.Empty);
            return View(obj);
        }


        public IActionResult DeleteAccountUser(int id)
        {
            try
            {
               AccountUserList pstList = new AccountUserList();
            pstList.DeleteAccountUser(id);
            return RedirectToAction("ListUser");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }



            
        }



        public IActionResult ListEmployee()
        {


            AccountEmployerList pst = new AccountEmployerList();
            List<AccountEmployer> obj = pst.getAccountEmployee(string.Empty);
            return View(obj);
        }

        public IActionResult DeleteAccountEmployee(int id)
        {

            try
            {
                AccountEmployerList pstList = new AccountEmployerList();
            pstList.DeleteAccountEmployee(id);
            return RedirectToAction("ListEmployee");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }




            
        }






        public IActionResult ListCV()
        {
            CVList pst = new CVList();
            List<CV> obj = pst.getCV(string.Empty);
            return View(obj);
        }


        public IActionResult DeleteCV(int id)
        {
            try
            {
                CVList pstList = new CVList();
                pstList.DeleteCV(id);
                return RedirectToAction("ListCV");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }




        }







    }
}
