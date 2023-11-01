using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestaodeVoluntarios.UI.Controllers
{
    [Authorize]
    public class VoluntariosEstudosController : Controller
    {
        private readonly IEstudoRepositorio _estudoRepositorio;
        private readonly IVoluntarioEstudoRepositorio _voluntarioEstudosRepositorio;
        private readonly IMasculinoCadastroRepositorio _masculinoCadastroRepositorio;
        private readonly IFemininoCadastroRepositorio _femininoCadastroRepositorio;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VoluntariosEstudosController(IEstudoRepositorio estudoRepositorio,
            IVoluntarioEstudoRepositorio voluntarioEstudosRepositorio,
            IMasculinoCadastroRepositorio masculinoCadastroRepositorio,
            IFemininoCadastroRepositorio femininoCadastroRepositorio,
            IHttpContextAccessor httpContextAccessor)
        {
            _estudoRepositorio = estudoRepositorio;
            _voluntarioEstudosRepositorio = voluntarioEstudosRepositorio;
            _masculinoCadastroRepositorio = masculinoCadastroRepositorio;
            _femininoCadastroRepositorio = femininoCadastroRepositorio;
            _httpContextAccessor = httpContextAccessor;
        }


        public IActionResult Index(int id, string sexo)
        {
            ViewBag.PerfilUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            ViewBag.TipoVoluntario = sexo;
            ViewBag.VoluntarioId = id;
            return sexo.Equals("M") ? VoluntarioMasculinoRetorno(id) : VoluntarioFemininoRetorno(id);
        }

        private IActionResult VoluntarioFemininoRetorno(int id)
        {
            try
            {
                var voluntarioCadastrado = _femininoCadastroRepositorio.SelecionarPorId(id);
                ViewData["CadastroVoluntarioId"] = voluntarioCadastrado.FemininoCadastroId;
                ViewData["CadastroNome"] = voluntarioCadastrado.CadastroNome;
                ViewData["Estudos"] = new SelectList(_estudoRepositorio.SelecionarTodos(), "Id", "Nome");
                var result = _voluntarioEstudosRepositorio.SelecionarTodos().Where(x => x.VoluntarioId == voluntarioCadastrado.FemininoCadastroId).ToList().OrderByDescending(y => y.DataEstudo);
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IActionResult VoluntarioMasculinoRetorno(int id)
        {
            try
            {
                var voluntarioCadastrado = _masculinoCadastroRepositorio.SelecionarPorId(id);
                ViewData["CadastroVoluntarioId"] = voluntarioCadastrado.MasculinoCadastroId;
                ViewData["CadastroNome"] = voluntarioCadastrado.CadastroNome;
                ViewData["Estudos"] = new SelectList(_estudoRepositorio.SelecionarTodos(), "Id", "Nome");
                var result = _voluntarioEstudosRepositorio.SelecionarTodos().Where(x => x.VoluntarioId == voluntarioCadastrado.MasculinoCadastroId).ToList().OrderByDescending(y => y.DataEstudo);
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateEstudo(VoluntarioEstudos voluntarioEstudo)
        {
            var retorno = string.Empty;
            if (ModelState.IsValid)
            {
                try
                {
                    var dataEstudo = DateTime.Compare(Convert.ToDateTime(voluntarioEstudo.DataEstudo), DateTime.Now.Date);
                    if (dataEstudo < 0)
                    {
                        retorno = "DATAMENOR";
                    }
                    else
                    {
                        if (!VerificaEstudoCadastrado(voluntarioEstudo.VoluntarioId, voluntarioEstudo.EstudoId))
                        {
                            voluntarioEstudo.LoginUsuario = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
                            var idInserido = _voluntarioEstudosRepositorio.Incluir(voluntarioEstudo);
                            voluntarioEstudo = _voluntarioEstudosRepositorio.SelecionarPorId(idInserido);
                            retorno = "OK";
                        }
                        else
                        {
                            retorno = "JAEXISTE";
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Json(retorno);
        }

        private bool VerificaEstudoCadastrado(int voluntarioId, int estudoId)
        {
            var usuarioLogado = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            var result = _voluntarioEstudosRepositorio.SelecionarTodos().
                                                       Where(x => x.VoluntarioId == voluntarioId && x.EstudoId == estudoId).ToList();

            if (result.Count > 0)
            {
                var dataEstudo = DateTime.Compare(Convert.ToDateTime(result[0].DataEstudo), DateTime.Now.Date);
                if (dataEstudo < 0)
                    return false;
                else
                    return true;
            }

            return false;
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var ret = false;
            if (ModelState.IsValid)
            {
                try
                {
                    if (_voluntarioEstudosRepositorio.Deletar(id))
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