using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PartidoBusiness
    {
        private PartidoDao partidoDao = new PartidoDao();

        public void CrearPartido(Partido partido)
        {
            if (string.IsNullOrWhiteSpace(partido.EquipoLocal) || string.IsNullOrWhiteSpace(partido.EquipoVisitante))
            {
                throw new ArgumentException("Los equipos local y/o visitante son obligatorios.");
            }

            if (int.TryParse(partido.EquipoLocal, out _) || int.TryParse(partido.EquipoVisitante, out _))
            {
                throw new ArgumentException("Los equipos local y/o visitante no pueden ser numericos.");
            }

            if (partido.EquipoLocal.Length <= 5 || partido.EquipoVisitante.Length <= 5)
            {
                throw new ArgumentException("Los nombres de los equipos deben tener mas de 5 caracteres.");
            }

            if (partido.FechaPartido < DateTime.Now.Date)
            {
                throw new ArgumentException("Los fecha del partido no puede ser menor a la fecha actual.");
            }

            if (partido.TipoDeporte.IdDeporte <= 0)
            {
                throw new ArgumentException("El campo deporte no puede estar vacio.");
            }

            partido.FechaRegistro = DateTime.Now;
            partido.MarcadorLocal = 0;
            partido.MarcadorVisitante = 0;

            partidoDao.InsertarPartido(partido);
        }

        public List<Partido> ObtenerPartidos() 
        {
            return partidoDao.ObtenerPartidos();
        }

        public void EliminarPartido(string idPartido)
        {
            if (!int.TryParse(idPartido, out int numPartido))
            {
                throw new ArgumentException("El ID del partido debe ser numerico.");
            }

            if (numPartido <= 0)
            {
                throw new ArgumentException("El ID del partido no es valido.");
            }

            Partido partido = ObtenerPartidoPorId(numPartido);

            if (partido == null)
            {
                throw new ArgumentException("No se encontro el partido.");
            }

            partidoDao.EliminarPartido(numPartido);
        }

        public void ModificarMarcador(string idPartido, string marcadorLocal, string marcadorVisitante)
        {
            if (!int.TryParse(idPartido, out int numPartido))
            {
                throw new ArgumentException("El ID del partido debe ser numerico.");
            }

            if (!int.TryParse(marcadorLocal, out int numMarcadorLocal))
            {
                throw new ArgumentException("El marcador local debe ser numerico.");
            }

            if (!int.TryParse(marcadorVisitante, out int numMarcadorVisitante))
            {
                throw new ArgumentException("El marcador visitante debe ser numerico.");
            }

            if (numPartido <= 0)
            {
                throw new ArgumentException("El ID del partido no es valido.");
            }

            if (numMarcadorLocal < 0 || numMarcadorVisitante < 0)
            {
                throw new ArgumentException("Campo marcador de goles invalido.");
            }

            Partido partido = ObtenerPartidoPorId(numPartido);
            
            if (partido == null)
            {
                throw new ArgumentException("No se encontro el partido.");
            }

            if (partido.FechaPartido.Date != DateTime.Today)
            {
                throw new ArgumentException("El partido no se juega hoy. No se puede modificar el marcador.");
            }

            partido.MarcadorLocal = numMarcadorLocal;
            partido.MarcadorVisitante = numMarcadorVisitante;

            partidoDao.ModificarMarcador(partido);
        }

        private Partido ObtenerPartidoPorId(int idPartido)
        {
            return partidoDao.ObtenerPartidoPorId(idPartido);
        }
    }
}
