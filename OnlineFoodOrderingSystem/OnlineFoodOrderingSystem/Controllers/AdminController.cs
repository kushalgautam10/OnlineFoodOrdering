using OnlineFoodOrderingSystem.Models;
using OnlineFoodOrderingSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineFoodOrderingSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        // GET: Admin
        OnlineFoodDBEntities _db = new OnlineFoodDBEntities();
        [Authorize(Roles = "Admin")]
        public ActionResult DashBoard()
        {
            return View();
        }
      

    }
}