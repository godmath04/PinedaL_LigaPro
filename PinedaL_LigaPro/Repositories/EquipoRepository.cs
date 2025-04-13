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
            if(equipos.Count == 0)
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
                PartidosPerdidos = 0
            };

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
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
    
    }
}
