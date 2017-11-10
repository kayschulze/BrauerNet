using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BrauerNet.Models;

namespace BrauerNet.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectRepository projectRepo;
        // GET: /<controller>/

		public ProjectsController(IProjectRepository thisRepo = null)
		{
			if (thisRepo == null)
			{
				this.projectRepo = new EFProjectRepository();
			}
			else
			{
				this.projectRepo = thisRepo;
			}
		}

		public IActionResult Index()
		{
			Project newProject = new Project();
			return View(newProject);
		}

		public IActionResult Details(int id)
		{
			ViewBag.thisProduct = projectRepo.Projects;
			var thisProduct = projectRepo.Projects.FirstOrDefault(x => x.ProjectId == id);
			return View(thisProduct);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Project project)
		{
			projectRepo.Save(project);
			return RedirectToAction("Index");
		}

		public IActionResult Edit(int id)
		{
			var thisProject = projectRepo.Projects.FirstOrDefault(x => x.ProjectId == id);
			return View(thisProject);
		}

		[HttpPost]
		public IActionResult Edit(Project project)
		{
			projectRepo.Edit(project);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			var thisProject = projectRepo.Projects.FirstOrDefault(x => x.ProjectId == id);
			return View(thisProject);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			Project thisProject = projectRepo.Projects.FirstOrDefault(x => x.ProjectId == id);
			projectRepo.Remove(thisProject);
			return RedirectToAction("Index");
		}
    }
}
