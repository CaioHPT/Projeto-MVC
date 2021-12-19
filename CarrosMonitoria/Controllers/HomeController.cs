using CarrosMonitoria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosMonitoria.Controllers
{
    public class HomeController : Controller
    {
        private  Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CadastrarOferta> oferta = _context.cadastrarOfertas.ToList();
            if(oferta == null){
                return View();
            }

            return View(oferta);
        }

        public IActionResult CadastrarPromocao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarPromocao(CadastrarOferta oferta)
        {
            _context.cadastrarOfertas.Add(oferta);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult CadastroCarro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCarro(CadastrarCarro carro)
        {
            _context.cadastrarCarros.Add(carro);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Carros()
        {
            List<CadastrarCarro> carros = _context.cadastrarCarros.ToList();

            if(carros == null)
            {
                return View();
            }

            return View(carros);
        }

        public IActionResult Comprar()
        {
            ViewBag.carros = new SelectList(_context.cadastrarCarros, "Id_Carro", "Nome_Carro");

            return View();
        }

        [HttpPost]
        public IActionResult Comprar(Comprar comprar)
        {
            _context.compras.Add(comprar);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Compras()
        {
            List<Comprar> compras = _context.compras.Include(compra => compra.CadastrarCarro).ToList();

            if(compras == null)
            {
                return View();
            }

            return View(compras);
        }

        public IActionResult Contato()
        {
            List<Contato> contatos = _context.contatos.ToList();

            ViewBag.contato = contatos;

            if(contatos == null)
            {
                return View();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Contato(Contato contato)
        {
            _context.contatos.Add(contato);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult EditarCarro(int id)
        {
            CadastrarCarro carro = _context.cadastrarCarros.Find(id);

            if(carro == null)
            {
                return RedirectToAction("Index");
            }

            return View(carro);
        }

        [HttpPost]
        public IActionResult EditarCarro(CadastrarCarro carro)
        {
   

            _context.cadastrarCarros.Update(carro);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult DeletarCarro(int id)
        {
            var carro = _context.cadastrarCarros.Find(id);

            if(carro == null)
            {
                return RedirectToAction("Carros");
            }

            _context.cadastrarCarros.Remove(carro);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeletarContato(int id)
        {
            var contato = _context.contatos.Find(id);

            _context.contatos.Remove(contato);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult EditarCompra()
        {
            return View();
        }

        public IActionResult EditarContato()
        {
            return View();
        }

        public IActionResult EditarOferta()
        {
            return View();
        }
    }
}
