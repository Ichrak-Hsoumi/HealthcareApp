using Chat.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public AdminController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {

            _context = context;
            _userManager = userManager;

        }




        public async Task<IActionResult> Index()
        {
            ViewBag.userName = _userManager.GetUserName(HttpContext.User);
            return View("Views/Admin/HomeAdmin.cshtml", await _context.Medecin.ToListAsync());
        }

        public IActionResult ListeMed()
        {
            var displaydata = _context.Medecin.ToList();
            return View(displaydata);
        }

        [HttpGet]
        public async Task<IActionResult> ListeMed(string docSearch)
        {
            ViewData["getDetails"] = docSearch;
            var docquery = from d in _context.Medecin select d;
            if (!String.IsNullOrEmpty(docSearch))
            {
                docquery = docquery.Where(d => d.CodeCnam.Contains(docSearch) || d.Specialite.Contains(docSearch) || d.nom.Contains(docSearch) || d.prenom.Contains(docSearch));
            }
            return View(await docquery.AsNoTracking().ToListAsync());
        }
    }
}
