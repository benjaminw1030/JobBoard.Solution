using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<JobOpening> allJobs = JobOpening.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateJob()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string name, string email, string phoneNumber)
    {
      ContactInfo myContactInfo = new ContactInfo(name, email, phoneNumber);
      JobOpening myJob = new JobOpening(title, description, myContactInfo);
      return RedirectToAction("Index");
    }
  }
}