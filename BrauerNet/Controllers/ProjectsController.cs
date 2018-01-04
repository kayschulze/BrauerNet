using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BrauerNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectRepository projectRepo;

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
            //ViewBag.theseProjects = projectRepo.Projects;
            //List<Goal> goalList = projectRep
            var projectsList = projectRepo.Projects
                .Include(p => p.GoalProjects)
                .ThenInclude(j => j.Goal)
                .ToList();

            return View(projectsList);
		}

		public IActionResult Details(int id)
		{
			ViewBag.thisProject = projectRepo.Projects;
            var thisProject = projectRepo.Projects
                .Include(p => p.GoalProjects)
                .ThenInclude(j => j.Goal)
                .FirstOrDefault(x => x.ProjectId == id);
			return View(thisProject);
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
            var thisProject = projectRepo.Projects
                .FirstOrDefault(x => x.ProjectId == id);
            return View(thisProject);
		}

		[HttpPost]
		public IActionResult Edit(Project project)
		{
            //int id = project.ProjectId;
            projectRepo.Edit(project);
            //projectRepo.Entry(project).State = EntityState.Modified;
            //projectRepo.SaveChanges();
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
			Project thisProject = projectRepo.Projects
                .FirstOrDefault(x => x.ProjectId == id);
			projectRepo.Remove(thisProject);
			return RedirectToAction("Index");
		}
    }
}
