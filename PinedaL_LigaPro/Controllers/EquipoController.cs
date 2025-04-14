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
            var equipos = _repository.DevuelveListadoEquipos()
                .OrderByDescending(e => e.TotalPuntos)
                .ToList();
            return View(equipos);
        }

        public IActionResult Details(int id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(id);
            if(equipo == null)
            {
                return NotFound();
            }
            return View(equipo);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _repository.CrearEquipo(equipo);
                return RedirectToAction("List");
            }
            return View(equipo);
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
            
                throw;
            }
        }

        public IActionResult Eliminar(int Id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarEliminar(int Id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            if (equipo == null)
            {
                return NotFound();
            }
            _repository.EliminarEquipo(Id);
            return RedirectToAction("List");

        }
    }
}
