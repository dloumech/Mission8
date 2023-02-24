using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // adding ViewTask View
        public IActionResult ViewTask()
        {
            return View();
        }

        public IActionResult AddTask()
        {
            return View();
        }

        /*
        [HttpGet]
        public IActionResult ViewTask()
        {
            var tasks = TaskSubmissionContext.Responses
                .ToList();
            return View(tasks);
        }
        [HttpGet]
        public IActionResult Edit(int TaskId)
        {
            ViewBag.Categories = TaskSubmissionContext.Category.ToList();
            var tasks = TaskSubmissionContext.Responses.Single(x => x.MovieId == applicationid);
            return View("AddTask", application);
        }
        [HttpPost]
        public IActionResult Edit(MovieResponse blah)
        {
            TaskSubmissionContext.Update(blah);
            TaskSubmissionContext.SaveChanges();
            return RedirectToAction("ViewTask");
        }
        [HttpGet]
        public IActionResult Delete(int TaskId)
        {
            var aTaskId = TaskSubmissionContext.Responses.Single(x => x.MovieId == TaskId);
            return View("Delete", application);
        }
        [HttpPost]
        public IActionResult Delete(MovieResponse blah)
        {
            TaskSubmissionContext.Responses.Remove(blah);
            TaskSubmissionContext.SaveChanges();
            return RedirectToAction("ViewTask");
        }

        [HttpGet]
        public IActionResult FillOutForm()
        {
            ViewBag.Categories = TaskSubmissionContext.Category.ToList();
            return View("MovieForm");
        }
        [HttpPost]
        public IActionResult FillOutForm(MovieResponse response)
        {
            if (ModelState.IsValid)
            {
                TaskSubmissionContext.Add(response);
                TaskSubmissionContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = TaskSubmissionContext.Category.ToList();
                return View(response);
            }
        }
         */
        // idk what where MovieId, FillOutForm(), and MovieResponse need to come from but the rest shoooould be done
        
    }
}

//test 