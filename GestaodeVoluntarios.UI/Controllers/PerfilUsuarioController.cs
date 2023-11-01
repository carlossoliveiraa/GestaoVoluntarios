using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GestaodeVoluntarios.UI.Controllers
{
    //[Authorize]
    public class PerfilUsuarioController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        public PerfilUsuarioController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}