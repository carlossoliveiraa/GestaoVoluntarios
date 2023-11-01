using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GestaodeVoluntarios.UI.Controllers
{
    [Authorize]
    public class VoluntariosFemininoInativosController : Controller
    {
        private readonly IFemininoCadastroRepositorio _femininoCadastroRepositorio;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration _configuration { get; private set; }

        public int QtdPaginacao => _configuration.GetValue<int>("Paginacao");

        public VoluntariosFemininoInativosController(IConfiguration configuration, IFemininoCadastroRepositorio femininoCadastroRepositorio, IHttpContextAccessor httpContextAccessor)
        {
            _femininoCadastroRepositorio = femininoCadastroRepositorio;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                var objetos = _femininoCadastroRepositorio.ObterCadastroFemininosTodos().OrderByDescending(z => z.Id).Where(x => x.Ativo == false).ToList();
                return View(objetos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GrupoPagina(int NrPagina)
        {
            try
            {
                var lista = _femininoCadastroRepositorio.ObterCadastroFemininoTodosSql(false, NrPagina, QtdPaginacao);
                return Json(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult FiltrarnoBackEnd(bool ativo, int femininoId, string classesocial, int idadeDe, int idadeAte, string nome)
        {
            try
            {
                var lista = _femininoCadastroRepositorio.FiltrarnoBackEnd(ativo, femininoId, classesocial, idadeDe, idadeAte, nome);
                return Json(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult DesableItem(int id)
        {
            var ret = false;
            if (ModelState.IsValid)
            {
                try
                {
                    if (_femininoCadastroRepositorio.AtivarDesativar(id, true))
                    {
                        ret = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return Json(ret);
        }
    }
}