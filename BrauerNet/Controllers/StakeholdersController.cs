using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BrauerNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Controllers
{
    public class StakeholdersController : Controller
    {
        private IStakeholderRepository stakeholderRepo;

        public StakeholdersController(IStakeholderRepository thisRepo = null)
        {
            if (thisRepo == null)
            {
                this.stakeholderRepo = new EFStakeholderRepository();
            }
            else
            {
                this.stakeholderRepo = thisRepo;
            }
        }

        public IActionResult Index()
        {
            var stakeholdersList = stakeholderRepo.Stakeholders
                .Include(p => p.ProjectStakeholders)
                .ToList();
            return View(stakeholdersList);
        }

        public IActionResult Details(int id)
        {
            ViewBag.thisStakeholder = stakeholderRepo.Stakeholders;
            var thisStakeholder = stakeholderRepo.Stakeholders
                .FirstOrDefault(x => x.StakeholderId == id);
            return View(thisStakeholder);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Stakeholder stakeholder)
        {
            stakeholderRepo.Save(stakeholder);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisStakeholder = stakeholderRepo.Stakeholders
                .FirstOrDefault(x => x.StakeholderId == id);
            return View(thisStakeholder);
        }

        [HttpPost]
        public IActionResult Edit(Stakeholder stakeholder)
        {
            stakeholderRepo.Edit(stakeholder);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisStakeholder = stakeholderRepo.Stakeholders
                .FirstOrDefault(x => x.StakeholderId == id);
            stakeholderRepo.Remove(thisStakeholder);
            return RedirectToAction("Index");
        }
    }
}
