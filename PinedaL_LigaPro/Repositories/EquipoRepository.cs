using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using PinedaL_LigaPro.Models;
namespace PinedaL_LigaPro.Repositories
{
    public class EquipoRepository
    {
        // Sugerencia de Lista static generada por IA
        public static List<Equipo> equipos = new List<Equipo>();

        public EquipoRepository()
        {
            if (equipos.Count == 0)
            {
                InicializarEquipos();
            }
        }

        public void InicializarEquipos()
        {
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                LogoUrl = "/images/ldu.jpg",
                Descripcion = "Fundado en 1930, LDU es uno de los equipos más importantes del país."
            };

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2,
                LogoUrl = "/images/bsc.jpg",
                Descripcion = "Barcelona SC es el equipo más popular de Ecuador, con sede en Guayaquil."
            };

            equipos.Add(ldu);
            equipos.Add(barcelona);

        }



        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {

            return equipos.OrderByDescending(e => e.TotalPuntos);

        }

        public Equipo DevuelveInformacionEquipo(int Id)
        {

            return equipos.FirstOrDefault(e => e.Id == Id);
        }

        public bool CrearEquipo(Equipo equipo)
        {
            equipo.Id = equipos.Max(e => e.Id) + 1;
            equipos.Add(equipo);
            return true;
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            var index = equipos.FindIndex(e => e.Id == equipo.Id);
            if (index != -1)
            {
                equipos[index] = equipo;
                return true;
            }
            return false;
        }

        public bool EliminarEquipo(int id)
        {
            var equipo = equipos.FirstOrDefault(e => e.Id == id);
            if (equipo != null)
            {
                equipos.Remove(equipo);
                return true;
            }
            return false;
        }
    
    }
}
