using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Migrations;
using GestaodeVoluntarios.UI.Models.Feminino;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GestaodeVoluntarios.UI.Controllers
{
    [Authorize]
    public class VoluntariosFemininoController : Controller
    {
        #region Propriedades
        private readonly IFemininoCadastroRepositorio _femininoCadastroRepositorio;

        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration _configuration { get; private set; }
        public int QtdPaginacao => _configuration.GetValue<int>("Paginacao");

        private readonly UserManager<IdentityUser> _userManager;

        #endregion

        public VoluntariosFemininoController(IConfiguration configuration, IFemininoCadastroRepositorio femininoCadastroRepositorio, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager)
        {
            _femininoCadastroRepositorio = femininoCadastroRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                ViewBag.QuantidadeMaximaLinhasPorPagina = QtdPaginacao;
                ViewBag.PaginaAtual = 1;
                var quantidadeRegistros = _femininoCadastroRepositorio.ObterCadastroFemininosTodos().Count();
                var lista = _femininoCadastroRepositorio.ObterCadastroFemininoTodosSql(true, ViewBag.PaginaAtual, QtdPaginacao);
                var difQuantidadePaginas = (quantidadeRegistros % QtdPaginacao) > 0 ? 1 : 0;
                ViewBag.QuantidadedePaginas = (quantidadeRegistros / QtdPaginacao) + difQuantidadePaginas;
                return View(lista);
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
                var lista = _femininoCadastroRepositorio.ObterCadastroFemininoTodosSql(true, NrPagina, QtdPaginacao);
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

        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(FemininoCadastro femininoCadastro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var FemininoCadastroMaxId = _femininoCadastroRepositorio.ObterCadastroFemininosTodos().Max(y => y.FemininoCadastroId)+1;
                    femininoCadastro.LoginUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
                    femininoCadastro.CadastroDataInclusao = DateTime.Now.ToShortDateString();
                    femininoCadastro.FemininoCadastroId = FemininoCadastroMaxId;
                    _femininoCadastroRepositorio.Incluir(femininoCadastro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(femininoCadastro.FemininoCadastroId);
        }

        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                ViewBag.Id = id;
                return View(_femininoCadastroRepositorio.SelecionarPorId(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, FemininoCadastro voluntariosFeminino)
        {
            if (id != voluntariosFeminino.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _femininoCadastroRepositorio.Alterar(voluntariosFeminino);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Json(voluntariosFeminino.FemininoCadastroId);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var ret = false;
            if (ModelState.IsValid)
            {
                try
                {
                    if (_femininoCadastroRepositorio.Deletar(id))
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

        [HttpPost]
        public IActionResult DesableItem(int id)
        {
            var ret = false;
            if (ModelState.IsValid)
            {
                try
                {
                    if (_femininoCadastroRepositorio.AtivarDesativar(id, false))
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
