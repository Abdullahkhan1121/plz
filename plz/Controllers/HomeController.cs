using Microsoft.AspNetCore.Mvc;
using plz.Models;
using System.Diagnostics;

namespace plz.Controllers
{
    public class HomeController : Controller
    {
        Connection db = new Connection();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Adddata()
        {
            return View("form");
        }
        [HttpPost]
        public IActionResult Adddata(string name , string email , string password , IFormFile image)
        {
            var filename = image.FileName;
            Student std = new Student(name , email , password , filename);
            db.students.Add(std);
            db.SaveChanges();
            ViewBag.student = "User Added";
            return View("form");
        }

        public IActionResult getdata()
        {
            var data = db.students.ToList();
            return View(data);
        }

        public IActionResult editdata(int id)
        {
            var data = db.students.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult editdata(int id , string name , string email , string password)
        {
            var data = db.students.Where(x => x.Id == id).FirstOrDefault();
            data.Name = name;
            data.Email = email;
            data.Password = password;
            db.SaveChanges();
            return RedirectToAction("getdata");
        }
    }
}