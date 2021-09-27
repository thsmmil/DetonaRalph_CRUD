using DetonaRalph_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetonaRalph_CRUD.Controllers
{
    public class PersonagensController : Controller
    {
        private readonly Contexto _contexto;
        public PersonagensController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Personagens.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarPersonagem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarPersonagem(Personagem personagem)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(personagem);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(personagem);
        }
        [HttpGet]
        public IActionResult AtualizarPersonagem(int? id)
        {
            if (id != null)
            {
                Personagem personagem = _contexto.Personagens.Find(id);
                return View(personagem);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarPersonagem(int? id, Personagem personagem)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(personagem);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(personagem);
            }
            else return NotFound();
        }
        [HttpGet]
        public IActionResult ExcluirPersonagem(int? id)
        {
            if (id != null)
            {
                Personagem personagem = _contexto.Personagens.Find(id);
                return View(personagem);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ExcluirPersonagem(int? id, Personagem personagem)
        {
            if (id != null)
            {
                _contexto.Remove(personagem);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
