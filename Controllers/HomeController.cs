using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private TaskSubmissionContext _taskContext { get; set; }

        public HomeController(ILogger<HomeController> logger, TaskSubmissionContext taskContext)
        {
            _logger = logger;
            _taskContext = taskContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _taskContext.Categories.ToList();
            return View("AddTask");
        }
        [HttpPost]
        public IActionResult AddTask(TaskResponse response)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Add(response);
                _taskContext.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = _taskContext.Categories.ToList();
                return View("AddTask", response);
            }
        }

        // adding ViewTask View
        [HttpGet]
        public IActionResult ViewTask()
        {
            var tasks = _taskContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Quadrant)
                .ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Edit(int TaskId)
        {
            ViewBag.Categories = _taskContext.Categories.ToList();
            var tasks = _taskContext.Responses.Single(x => x.TaskId == TaskId);
            return View("AddTask", tasks);
        }

        [HttpPost]
        public IActionResult Edit(TaskResponse tr)
        {
            _taskContext.Update(tr);
            _taskContext.SaveChanges();

            return RedirectToAction("ViewTask");
        }

        [HttpGet]
        public IActionResult Delete(int TaskId)
        {
            var aTaskId = _taskContext.Responses.Single(x => x.TaskId == TaskId);
            
            return View(aTaskId);
        }
        [HttpPost]
        public IActionResult Delete(TaskResponse tr)
        {
            _taskContext.Responses.Remove(tr);
            _taskContext.SaveChanges();
            return RedirectToAction("ViewTask");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//test 