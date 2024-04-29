﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using odontoschedule_backand.Models;

namespace odontoschedule_backand.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veiculos.ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Veiculos.Add(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(veiculo);
        }

        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
                return View();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View();

        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Veiculo veiculo)
        {
            if (id != veiculo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Veiculos.Update(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View();

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View(dados);



        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();
            _context.Veiculos.Remove(dados);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");



        }

    }
}
     