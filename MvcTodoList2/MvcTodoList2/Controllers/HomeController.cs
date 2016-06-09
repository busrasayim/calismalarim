using MvcTodoList2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTodoList2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult AnaSayfa()
        {
            TodoList2Context db = new TodoList2Context();

            // Veritabanından tamamlanmamış görevler çekilir.
            IEnumerable<TaskItem> tasks = from x in db.TaskItems
                                          where x.IsCompleted == false
                                          select x;

            return View(tasks.ToList());
        }

        public ActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(TaskItem task)
        {
            TodoList2Context db = new TodoList2Context();

            task.CreatedOn = DateTime.Now;
            task.IsCompleted = false;

            db.TaskItems.Add(task);
            db.SaveChanges();

            return RedirectToAction("AnaSayfa", "Home");
        }

        // Get : /Home/Edit/2
        public ActionResult Edit(int id)
        {
            TodoList2Context db = new TodoList2Context();

            TaskItem item = db.TaskItems.Where(x => x.Id == id).SingleOrDefault();

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(TaskItem item)
        {
            TodoList2Context db = new TodoList2Context();

            TaskItem db_item = db.TaskItems.Where(x => x.Id == item.Id).SingleOrDefault();
            db_item.Description = item.Description;
            db_item.ModifiedOn = DateTime.Now;

            db.SaveChanges();

            return RedirectToAction("AnaSayfa");
        }

        public ActionResult Completed(int id)
        {
            TodoList2Context db = new TodoList2Context();

            TaskItem db_item = db.TaskItems.Where(x => x.Id == id).SingleOrDefault();
            db_item.IsCompleted = true;
            db_item.ModifiedOn = DateTime.Now;

            db.SaveChanges();

            return RedirectToAction("CompletedTasks");
        }

        // GET : /Home/Delete/12
        public ActionResult Delete(int id)
        {
            TodoList2Context db = new TodoList2Context();

            TaskItem item = db.TaskItems.Where(x => x.Id == id).SingleOrDefault();

            return View(item);
        }

        public ActionResult CompletedTasks()
        {
            TodoList2Context db = new TodoList2Context();

            IEnumerable<TaskItem> list = db.TaskItems.Where(x => x.IsCompleted == true);

            return View(list);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            TodoList2Context db = new TodoList2Context();

            TaskItem item = db.TaskItems.Where(x => x.Id == id).SingleOrDefault();

            db.TaskItems.Remove(item);
            db.SaveChanges();

            return RedirectToAction("AnaSayfa");
        }


        public ActionResult AddMultiTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMultiTask(List<TaskItem> items)
        {
            if (items != null && items.Count > 0)
            {
                TodoList2Context db = new TodoList2Context();

                items.ForEach(x => x.CreatedOn = DateTime.Now);

                db.TaskItems.AddRange(items);
                db.SaveChanges();
            }

            return RedirectToAction("AnaSayfa");
        }
    }
}