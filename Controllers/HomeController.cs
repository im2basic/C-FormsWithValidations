using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
        // public MyModel(string firstName, string lastName, int age, string email, string password) 
        // {
        //     this.FirstName = firstName;
        //     this.LastName = lastName;
        //     this.Age = age;
        //     this.Email = email;
        //     this.Password = password;
        // }
            return View("Index");
        }

        [HttpPost("success")]
        public IActionResult Success(MyModel newUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return View("Success");
        }


    }
}
