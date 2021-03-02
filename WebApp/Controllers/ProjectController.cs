using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ProjectController : Controller
    {
        // GET ALL PROJECTS
        public IActionResult Index()
        {

            GenralCRUD objCRUID = new GenralCRUD();

            List<ProjectInfo> lstProjects = objCRUID.GetProjectAsList();

            return View(lstProjects);
        }

        // CREATE PROJECT
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectInfo obj)
        {
            GenralCRUD objCRUID = new GenralCRUD();
            objCRUID.AddProject(obj);
            return RedirectToAction("Index");
        }

        // EDIT PROJECT
        public IActionResult Edit(int? id)
        {
            GenralCRUD objCRUD = new GenralCRUD();
            object project = objCRUD.GetProject(id);
            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(ProjectInfo obj)
        {
            if (ModelState.IsValid)
            {
                GenralCRUD objCRUID = new GenralCRUD();
                objCRUID.UpdateProject(obj);
                return RedirectToAction("Index");
            } else
            {
                ViewBag.Message = "Project name is required!";
                return View();
            }
        }

        // DELETE PROJECT
        public IActionResult Delete(int? id)
        {
            GenralCRUD objCRUD = new GenralCRUD();
            object project = objCRUD.GetProject(id);
            return View(project);
        }

        [HttpPost]
        public IActionResult Delete (ProjectInfo obj) {
            GenralCRUD objCRUID = new GenralCRUD();
            int id = obj.ProjectID;
            objCRUID.DeleteProject(id);
            return RedirectToAction("Index");
        }
    }
}
