using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskListWebApp.Models;

namespace TaskListWebApp.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly TaskListDbContext _context;
        public TaskController(TaskListDbContext _context)
        {
            this._context = _context;
        }
        public IActionResult TaskIndex()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Tasks> tasksOfUser = _context.Tasks.Where(x => x.UserId == id).ToList();
            return View(tasksOfUser);
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            newTask.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.TaskNotAdded = "Unable to add task";
                return View();
            }
            return RedirectToAction("TaskIndex");
        }

        public IActionResult ToggleStatus(int id)
        {
            Tasks targetTask = _context.Tasks.Find(id);

            if (targetTask != null)
            {
                targetTask.Complete = !targetTask.Complete;
                _context.Entry(targetTask).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(targetTask);
                _context.SaveChanges();
            }

            return RedirectToAction("TaskIndex");
        }
        public IActionResult DeleteTask(int id)
        {
            Tasks targetTask = _context.Tasks.Find(id);

            if (targetTask != null)
            {
                _context.Tasks.Remove(targetTask);
                _context.SaveChanges();
            }

            return RedirectToAction("TaskIndex");
        }

        public IActionResult ShowComplete()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Tasks> tasksOfUser = _context.Tasks.Where(x => x.UserId == id).ToList();
            return View(tasksOfUser);
        }

        public IActionResult SearchDescription(string searchTerm)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Tasks> tasksOfUser = _context.Tasks.Where(x => x.Description.Contains(searchTerm)).ToList();
            return View(tasksOfUser);
        }
    }
}
