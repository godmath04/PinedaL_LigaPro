using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PinedaL_LigaPro.Models;
using PinedaL_LigaPro.Repositories;

namespace PinedaL_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        EquipoRepository repositorio = new EquipoRepository();
        var equipos = repositorio.DevuelveListadoEquipos();
        return View(equipos);
    }

}
