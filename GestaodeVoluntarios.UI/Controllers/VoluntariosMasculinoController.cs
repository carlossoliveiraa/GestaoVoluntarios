using System;
using System.Linq;
using System.Security.Claims;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models.Masculino;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GestaodeVoluntarios.UI.Controllers
{
    [Authorize]
    public class VoluntariosMasculinoController : Controller
    {
        #region Propriedades
        private readonly IMasculinoCadastroRepositorio _masculinoCadastroRepositorio;

        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration _configuration { get; private set; }
        public int QtdPaginacao => _configuration.GetValue<int>("Paginacao");
        #endregion

        public VoluntariosMasculinoController(IConfiguration configuration, 
            IMasculinoCadastroRepositorio masculinoCadastroRepositorio, 
            IHttpContextAccessor httpContextAccessor)
        {
            _masculinoCadastroRepositorio = masculinoCadastroRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;             
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                ViewBag.QuantidadeMaximaLinhasPorPagina = QtdPaginacao;
                ViewBag.PaginaAtual = 1;
                var quantidadeRegistros = _masculinoCadastroRepositorio.ObterCadastroMasculinosTodos().Count();
                var lista = _masculinoCadastroRepositorio.ObterCadastroMasculinosTodosSql(true, ViewBag.PaginaAtual, QtdPaginacao);
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
                var lista = _masculinoCadastroRepositorio.ObterCadastroMasculinosTodosSql(true, NrPagina, QtdPaginacao);
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

     
        [HttpPost]
        public IActionResult Create(MasculinoCadastro masculinoCadastro)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    {
                        var masculinoCadastroMaxId = _masculinoCadastroRepositorio.ObterCadastroMasculinosTodos().Max(y => y.MasculinoCadastroId) + 1;
                        masculinoCadastro.LoginUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
                        masculinoCadastro.CadastroDataInclusao = DateTime.Now.ToShortDateString();
                        masculinoCadastro.MasculinoCadastroId = masculinoCadastroMaxId;
                        _masculinoCadastroRepositorio.Incluir(masculinoCadastro);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Json(masculinoCadastro.MasculinoCadastroId);
        }

        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                var ret = _masculinoCadastroRepositorio.SelecionarPorId(id);
                ViewBag.VoluntarioMasculinoId = ret.MasculinoCadastroId;
                return View(ret);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, MasculinoCadastro voluntariosMasculino)
        {
            if (id != voluntariosMasculino.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _masculinoCadastroRepositorio.Alterar(voluntariosMasculino);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Json(voluntariosMasculino.MasculinoCadastroId);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var ret = false;
            if (ModelState.IsValid)
            {
                try
                {
                    if (_masculinoCadastroRepositorio.Deletar(id))
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
                    if (_masculinoCadastroRepositorio.AtivarDesativar(id, false))
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
