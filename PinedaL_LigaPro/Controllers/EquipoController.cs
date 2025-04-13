using Microsoft.AspNetCore.Mvc;
using PinedaL_LigaPro.Models;
using PinedaL_LigaPro.Repositories;

namespace PinedaL_LigaPro.Controllers
{

    public class EquipoController : Controller
    {

        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public IActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            return View(equipos);
        }

        public IActionResult EditarEquipo(int Id)
        {

            var equipo = _repository.DevuelveInformacionEquipo(Id);

            return View(equipo);
        }
        [HttpPost]
        public IActionResult GuardarEquipo(Equipo equipo)
        {

            try
            {
                _repository.ActualizarEquipo(equipo);
                return RedirectToAction("List");
            }
            catch (Exception e)
            {
                //logica para actualizar
                throw;
            }
        }
    }
}
