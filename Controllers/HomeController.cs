using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Resumes.Models;

namespace Resumes.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
        public ActionResult Index()
        {
          List<Resume> allJobs = Resume.GetAll();
          return View (allJobs);
        }
    [HttpPost("/")]
        public ActionResult Create()
        {
          Resume newResume = new Resume(Request.Form["bizName"], Request.Form["jobTitle"], Request.Form["jobDescription"], Request.Form["duration"], Convert.ToInt32(Request.Form["finalWage"]), Request.Form["mail"],Convert.ToInt32(Request.Form["phone"]));
          newResume.JobSave();
          List<Resume> allJobs = Resume.GetAll();
          return View (allJobs);
        }



  }
}
