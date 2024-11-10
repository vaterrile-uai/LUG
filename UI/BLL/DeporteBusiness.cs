using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeporteBusiness
    {
        private DeporteDao deporteDao = new DeporteDao();

        public List<TipoDeporte> ObtenerDeportes()
        {
            return deporteDao.ObtenerDeportes();
        }

    }
}
