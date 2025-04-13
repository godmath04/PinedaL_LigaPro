using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PinedaL_LigaPro.Models;

namespace PinedaL_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        List<Equipo> equipos = new List<Equipo>();


        public IActionResult List()
        {
            return View(equipos);
        }
    }

}
