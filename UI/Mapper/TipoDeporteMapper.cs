using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TipoDeporteMapper
    {
        public static TipoDeporte Map(SqlDataReader sqlDataReader)
        {
            TipoDeporte deporte = new TipoDeporte();
            deporte.IdDeporte = Convert.ToInt32(sqlDataReader["ID_DEPORTE"]);
            deporte.Descripcion = sqlDataReader["DESCRIPCION"].ToString();
            return deporte;
        }
    }
}
