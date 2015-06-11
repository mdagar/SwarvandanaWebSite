using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;

namespace SwarvandanaWebSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Faculty()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }

        public ActionResult Affiliations()
        {
            return View();
        }

        public ActionResult Vision()
        {
            return View();
        }

        public ActionResult Franchise()
        {
            return View();
        }

        public ActionResult videos()
        {
            return View();
        }

        public ActionResult corporate()
        {
            return View();
        }
        public ActionResult Schools()
        {
            return View();
        }
        public ActionResult Mall()
        {
            return View();
        }
        public ActionResult MusicTherapy()
        {
            return View();
        }
        public ActionResult ManagementTeam()
        {
            return View();
        }

        public ActionResult SendMal(string name, string emailaddress, string contact, string address, string message)
        {
            string content = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\MailFormats\notification.html"));
            content = content
                     .Replace("{name}", name).Replace("{Email}", emailaddress).Replace("{Contact}", contact).Replace("{Address}", address)
                     .Replace("{Message}", message);

            //MailHelper.SendEmail(SessionWrapper.Users.EmailAddress, Messages.AccountUploadMailSubject, content);
            MailHelper.SendMail("info@swarvandana.com", "New enquery from swarvandana.com", content);            
            return Json("", JsonRequestBehavior.AllowGet);
        }


    }
}
