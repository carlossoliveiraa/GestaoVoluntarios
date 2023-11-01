using System;
using System.Linq;
using System.Security.Claims;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GestaodeVoluntarios.UI.Controllers
{
    [Authorize]
    public class VoluntariosMasculinoInativosController : Controller
    {
        private readonly IMasculinoCadastroRepositorio _masculinoCadastroRepositorio;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration _configuration { get; private set; }
        public int QtdPaginacao => _configuration.GetValue<int>("Paginacao");

        public VoluntariosMasculinoInativosController(IConfiguration configuration,IMasculinoCadastroRepositorio masculinoCadastroRepositorio, IHttpContextAccessor httpContextAccessor)
        {
            _masculinoCadastroRepositorio = masculinoCadastroRepositorio;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                var objetos = _masculinoCadastroRepositorio.ObterCadastroMasculinosTodos().OrderByDescending(z => z.Id).Where(x=> x.Ativo == false) .ToList();
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
                var lista = _masculinoCadastroRepositorio.ObterCadastroMasculinosTodosSql(false, NrPagina, QtdPaginacao);
                return Json(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult FiltrarnoBackEnd(bool ativo, int masculinoId, string classesocial, int idadeDe, int idadeAte, string nome)
        {
            try
            {
                var lista = _masculinoCadastroRepositorio.FiltrarnoBackEnd(ativo, masculinoId, classesocial, idadeDe, idadeAte, nome);
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
                    if (_masculinoCadastroRepositorio.AtivarDesativar(id, true))
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