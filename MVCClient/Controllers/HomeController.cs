using MVCClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCClient.Controllers
{
    
    public class HomeController : Controller
    {
        private ServiceReference1.ServiceClient client;
        public HomeController()
        {
            client = new ServiceReference1.ServiceClient();
        }
        public ActionResult Index()
        {
            return View(client.GetStudents());
        }
        public ActionResult Test()
        {
            return View(client.GetStudents());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Gender,Birthday,Introducing")] Student student)
        {
            if (ModelState.IsValid)
            {
                client.Add(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                TempData[""] = "Student not exist";
                return RedirectToAction("Index");
            }
            Student student = client.Edit(id);
            if (student == null)
            {
                TempData["error"] = "Student not exist";
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Gender,Birthday,Introducing")] Student student)
        {
            if (ModelState.IsValid)
            {
                client.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}