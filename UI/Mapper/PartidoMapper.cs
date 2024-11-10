using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PartidoMapper
    {
        public static Partido Map(SqlDataReader sqlDataReader, TipoDeporte tipoDeporte)
        {
            Partido partido = new Partido
            {
                IdPartido = Convert.ToInt32(sqlDataReader["ID_PARTIDO"]),
                EquipoLocal = sqlDataReader["EQUIPO_LOCAL"].ToString(),
                EquipoVisitante = sqlDataReader["EQUIPO_VISITANTE"].ToString(),
                FechaRegistro = Convert.ToDateTime(sqlDataReader["FECHA_REGISTRO"]),
                FechaPartido = Convert.ToDateTime(sqlDataReader["FECHA_PARTIDO"]),
                MarcadorLocal = Convert.ToInt32(sqlDataReader["MARCADOR_LOCAL"]),
                MarcadorVisitante = Convert.ToInt32(sqlDataReader["MARCADOR_VISITANTE"]),
                TipoDeporte = tipoDeporte
            };
            return partido;
        }
    }
}
