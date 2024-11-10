using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoDeporte
    {
        private int idDeporte;
        private string descripcion;
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
