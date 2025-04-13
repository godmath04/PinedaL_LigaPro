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
                PartidosPerdidos = 0,
                TotalPuntos = 30
            };

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 0,
                PartidosPerdidos = 9,
                TotalPuntos = 3
            };
            equipos.Add (ldu);
            equipos.Add(bsc);



            return equipos;

        }
    }
}
