using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestaodeVoluntarios.UI.Models;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace GestaodeVoluntarios.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMasculinoCadastroRepositorio _masculinoCadastroRepositorio;
        private readonly IFemininoCadastroRepositorio _femininoCadastroRepositorio;
        public HomeController(ILogger<HomeController> logger, IMasculinoCadastroRepositorio masculinoCadastroRepositorio,
            IFemininoCadastroRepositorio femininoCadastroRepositorio)
        {
            _logger = logger;
            _masculinoCadastroRepositorio = masculinoCadastroRepositorio;
            _femininoCadastroRepositorio = femininoCadastroRepositorio;
        }

        public IActionResult Index()
        {
            try
            {
                return View(TodosVoluntarios());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TodosVoluntarios TodosVoluntarios()
        {
            try
            {
                var todosvoluntarios = new TodosVoluntarios();

                var feminino = _femininoCadastroRepositorio.SelecionarTodos();
                todosvoluntarios.QtdeVoluntarioFemininoAtivo = feminino.Where(x => x.Ativo.Equals(true)).Count();
                todosvoluntarios.QtdeVoluntarioFemininoInativo = feminino.Where(x => x.Ativo.Equals(false)).Count();

                var masculino = _masculinoCadastroRepositorio.SelecionarTodos();
                todosvoluntarios.QtdeVoluntarioMasculinoAtivo = masculino.Where(x => x.Ativo.Equals(true)).Count();
                todosvoluntarios.QtdeVoluntarioMasculinoInativo = masculino.Where(x => x.Ativo.Equals(false)).Count();

                return todosvoluntarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
