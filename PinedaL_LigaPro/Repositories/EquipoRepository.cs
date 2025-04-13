using PinedaL_LigaPro.Models;
namespace PinedaL_LigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo> ();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "lDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 0,
                PartidosPerdidos = 9
               
            };
            equipos.Add (ldu);
            equipos.Add(bsc);
            // Esto es para ordenar
            equipos = equipos.OrderBy(item => item.TotalPuntos).ToList();

            return equipos;

        }
    
        public Equipo DevuelveInformacionEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            // Esto es usando lambda
            var equipo = equipos.First(item => item.Id == Id);

            return equipo;
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            //Logica para actualizar
            return true; 
        }
    
    }
}
