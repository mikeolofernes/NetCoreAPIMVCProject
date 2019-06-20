using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Time_Tracking.Models;

namespace Time_Tracking.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users user)
        {
            //if (ModelState.IsValid)   
            //{  
            //    using(DB_Entities db = new DB_Entities())  
            //    {  
            //        var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();  
            //        if (obj != null)  
            //        {  
            //            Session["UserID"] = obj.UserId.ToString();  
            //            Session["UserName"] = obj.UserName.ToString();  
            //            return RedirectToAction("UserDashBoard");  
            //        }  
            //    }  
            //}  
            //return View(objUser);  
           
            if (ValidateUser(user.username,user.pword) == 1)
            {
                //Session["UserID"] = 1;
                //Session["UserName"] = username;
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public Int32 ValidateUser(string username, string pword)
        {
            if (username == "mike" && pword == "test123")
            {
                return 1;
            }

            return 0;
        }
        public ActionResult Logout()
        {

            //FormsAuthentication.SignOut();
            //Session.Clear();
            
            return RedirectToAction("Index", "Login");
        }


    }
}