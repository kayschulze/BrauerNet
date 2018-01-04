using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using BrauerNet.Models;
using BrauerNet.ViewModels;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrauerNet.Controllers
{
    public class ParticipantsController : Controller
    {
        private readonly BrauerNetDbContext _db;
        private readonly UserManager<Participant> _userManager;
        private readonly SignInManager<Participant> _signInManager;

        public ParticipantsController(UserManager<Participant> userManager, SignInManager<Participant> signInManager, BrauerNetDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var participantsList = _db
                .Participants
                .ToList();

            return View(participantsList);
        }

        /**public IActionResult Details(int id)
        {
            ViewBag.thisParticipant = _db.Participants;
            var thisProject = _db
                .Participants
                .FirstOrDefault(x => x.ParticipantId == id);
            return View(thisProject);
        }**/

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ParticipantViewModel model)
        {
            var participant = new Participant { UserName = model.Email };
            IdentityResult result = await _userManager.CreateAsync(participant, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisParticipant = _db.Participants
                .FirstOrDefault(x => x.ParticipantId == id);
            return View(thisParticipant);
        }

        /**[HttpPost]
        public IActionResult Edit(Participant participant)
        {
            _db.Edit(participant);
            return RedirectToAction("Index");
        } **/

        public IActionResult Delete(int id)
        {
            var thisParticipant = _db.Participants.FirstOrDefault(x => x.ParticipantId == id);
            return View(thisParticipant);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Participant thisParticipant = _db.Participants.FirstOrDefault(x => x.ParticipantId == id);
            _db.Remove(thisParticipant);
            return RedirectToAction("Index");
        }
    }
}

