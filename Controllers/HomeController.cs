using FrontierCodingTest.Enums;
using FrontierCodingTest.Models;
using FrontierCodingTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FrontierCodingTest.Controllers
{
    public class HomeController : Controller
    {
        
        public async Task<ActionResult> Index()
        {
            AccountService accountService = new AccountService();
            var accounts =  await accountService.GetAccounts();
            List<AccountsByStatus> accountsByStatus = accountService.GetAccountsByStatus(accounts);
            ViewBag.AccountsByStatuses = accountsByStatus;
            return View();
        }

      
    }
}
