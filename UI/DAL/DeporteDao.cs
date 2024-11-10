using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeporteDao
    {
        public List<TipoDeporte> ObtenerDeportes()
        {
            try
            {
                List<TipoDeporte> deportes = new List<TipoDeporte>();
                string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string querySelect = "SELECT * FROM DEPORTE";

                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                deportes.Add(TipoDeporteMapper.Map(sqlDataReader));
                            }
                        }
                    }
                }
                return deportes;
            }
            catch (Exception ex)
            {
                throw new Exception("DeporteDao.ObtenerDeportes: " + ex.Message);
            }
        }

        public TipoDeporte ObtenerDeportesId(int idTipoDeporte)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string querySelect = "SELECT * FROM DEPORTE WHERE ID_DEPORTE = @id";

                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", idTipoDeporte);
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                return TipoDeporteMapper.Map(sqlDataReader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("DeporteDao.ObtenerDeportesId: " + ex.Message);
            }
        }
    }
}
