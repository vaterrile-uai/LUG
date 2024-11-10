using Entity;
using Mapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartidoDao
    {
        private DeporteDao deporteDao = new DeporteDao();
        public void EliminarPartido(int idPartido)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string queryDelete = "DELETE FROM PARTIDO WHERE ID_PARTIDO = @IdPartido";
                    using (SqlCommand sqlCommand = new SqlCommand(queryDelete, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdPartido", idPartido);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PartidoDao.EliminarPartido: " + ex.Message);
            }
        }

        public void InsertarPartido(Partido partido)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string queryInsert = "INSERT INTO PARTIDO (ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE) " +
                                                      "VALUES (@IdDeporte, @EquipoLocal, @EquipoVisitante, @FechaRegistro, @FechaPartido, @MarcadorLocal, @MarcadorVisitante)";
                    using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdDeporte", partido.TipoDeporte.IdDeporte);
                        sqlCommand.Parameters.AddWithValue("@EquipoLocal", partido.EquipoLocal);
                        sqlCommand.Parameters.AddWithValue("@EquipoVisitante", partido.EquipoVisitante);
                        sqlCommand.Parameters.AddWithValue("@FechaRegistro", partido.FechaRegistro);
                        sqlCommand.Parameters.AddWithValue("@FechaPartido", partido.FechaPartido);
                        sqlCommand.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                        sqlCommand.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PartidoDao.InsertarPartido: " + ex.Message);
            }
        }

        public void ModificarMarcador(Partido partido)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string queryUpdate = "UPDATE PARTIDO SET MARCADOR_LOCAL = @MarcadorLocal, MARCADOR_VISITANTE = @MarcadorVisitante WHERE ID_PARTIDO = @IdPartido";
                    
                    using (SqlCommand sqlCommand = new SqlCommand(queryUpdate, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                        sqlCommand.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);
                        sqlCommand.Parameters.AddWithValue("@IdPartido", partido.IdPartido);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PartidoDao.ModificarPartido: " + ex.Message);
            }
        }

        public Partido ObtenerPartidoPorId(int idPartido)
        {
            Partido partido = null;
            string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string querySelect = "SELECT P.ID_PARTIDO, P.ID_DEPORTE, P.EQUIPO_LOCAL, P.EQUIPO_VISITANTE, P.FECHA_REGISTRO, P.FECHA_PARTIDO, " + 
                                         "       P.MARCADOR_LOCAL, P.MARCADOR_VISITANTE, D.DESCRIPCION " +
                                         "  FROM PARTIDO P, DEPORTE D " + 
                                         " WHERE P.ID_PARTIDO = @IdPartido AND P.ID_DEPORTE = D.ID_DEPORTE";

                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdPartido", idPartido);
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                TipoDeporte tipoDeporte = TipoDeporteMapper.Map(sqlDataReader);
                                partido = PartidoMapper.Map(sqlDataReader, tipoDeporte);
                            }
                        }
                    }
                }
                return partido;
            }
            catch (Exception ex)
            {
                throw new Exception("PartidoDao.ObtenerPartidoPorId: " + ex.Message);
            }
        }

        public List<Partido> ObtenerPartidos()
        {
            List<Partido> partidos = new List<Partido>();
            string connectionString = ConfigurationManager.ConnectionStrings["PrimerParcialDBConnection"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string querySelect = "SELECT * FROM PARTIDO";

                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                TipoDeporte tipoDeporte = deporteDao.ObtenerDeportesId(Convert.ToInt32(sqlDataReader["ID_DEPORTE"].ToString()));
                                Partido partido = PartidoMapper.Map(sqlDataReader, tipoDeporte);
                                partidos.Add(partido);
                            }
                        }
                    }
                }
                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception("PartidoDao.ObtenerPartidos: " + ex.Message);
            }
        }
    }
}
