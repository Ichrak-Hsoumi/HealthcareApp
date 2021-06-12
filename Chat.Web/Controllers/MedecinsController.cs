using Chat.Web.Data;
using Chat.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Controllers
{
    public class MedecinsController : Controller
    {
        private readonly ApplicationDbContext _context;


        public MedecinsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Medecins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medecin.ToListAsync());
        }

        // GET: Medecins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medecin = await _context.Medecin
                .FirstOrDefaultAsync(m => m.id == id);
            if (medecin == null)
            {
                return NotFound();
            }

            return View(medecin);
        }

        // GET: Medecins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medecins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nom,prenom,age,Adresse,CodeCnam,Disponibilite,Email,Experience,Password,Specialite,Tel,Universite")] Medecin medecin)
        {



            if (ModelState.IsValid)
            {

                _context.Add(medecin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medecin);
        }

        // GET: Medecins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medecin = await _context.Medecin.FindAsync(id);
            if (medecin == null)
            {
                return NotFound();
            }
            return View(medecin);
        }

        // POST: Medecins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nom,prenom,age,Adresse,CodeCnam,Disponibilite,Email,Experience,Password,Specialite,Tel,Universite")] Medecin medecin)
        {
            if (id != medecin.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medecin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedecinExists(medecin.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medecin);
        }

        // GET: Medecins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medecin = await _context.Medecin
                .FirstOrDefaultAsync(m => m.id == id);
            if (medecin == null)
            {
                return NotFound();
            }

            return View(medecin);
        }

        // POST: Medecins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medecin = await _context.Medecin.FindAsync(id);
            _context.Medecin.Remove(medecin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedecinExists(int id)
        {
            return _context.Medecin.Any(e => e.id == id);
        }
    }
}
