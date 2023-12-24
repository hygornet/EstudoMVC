using EstudoMVC.Context;
using EstudoMVC.Models;
using EstudoMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EstudoMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepositorioFuncionario _repositorioFuncionario;

        public HomeController(IRepositorioFuncionario context)
        {
            _repositorioFuncionario = context;
        }

        public IActionResult Index()
        {
            var funcionarios = _repositorioFuncionario.GetAllFuncionarios();
            
            return View(funcionarios);
        }

        public IActionResult Criar()
        {
            ViewBag.SetorName = _repositorioFuncionario.GetAllSetor();

            return View();
        }

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            ViewBag.SetorName = _repositorioFuncionario.GetAllSetor();
            _repositorioFuncionario.Adicionar(funcionario);

            return RedirectToAction("Index");
        }

        public IActionResult Search(string NomeFuncionario)
        {
            ViewBag.SetorName = _repositorioFuncionario.GetAllSetor();

            
            var funcionarios = _repositorioFuncionario.SearchFuncionario(NomeFuncionario);
            return View(funcionarios);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
