using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        private DeporteBusiness deporteBusiness = new DeporteBusiness();
        private PartidoBusiness partidoBusiness = new PartidoBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Partido partido = new Partido();
                partido.TipoDeporte = new TipoDeporte();
                partido.TipoDeporte.IdDeporte = Convert.ToInt32(cmbDeporte.SelectedValue);
                partido.EquipoLocal = txbEquipoLocal.Text;
                partido.EquipoVisitante = txbEquipoVisitante.Text;
                partido.FechaPartido = dtpFechaDelPartido.Value;

                partidoBusiness.CrearPartido(partido);
                MessageBox.Show("Partido cargado.");
                CargarPartidos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                throw new Exception("Form1.btnGuardar_Click: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                partidoBusiness.EliminarPartido(txbEliminarPartidoId.Text);
                MessageBox.Show("Partido eliminado.");
                CargarPartidos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                throw new Exception("Form1.btnEliminar_Click: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                partidoBusiness.ModificarMarcador(txbActualizarPartidoId.Text, txbMarcadorLocal.Text, txbMarcadorVisitante.Text);
                MessageBox.Show("Partido modificado.");
                CargarPartidos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                throw new Exception("Form1.btnModificar_Click: " + ex.Message);
            }
        }

        private void CargarPartidos()
        {
            List<Partido> partidos = partidoBusiness.ObtenerPartidos();
            dgvPartidos.DataSource = partidos;
        }

        private void CargarDeportes()
        {
            List<TipoDeporte> deportes = deporteBusiness.ObtenerDeportes();
            cmbDeporte.DataSource = deportes;
            cmbDeporte.DisplayMember = "Descripcion";
            cmbDeporte.ValueMember = "IdDeporte";
        }

        private void LimpiarCampos()
        {
            txbEquipoLocal.Clear();
            txbEquipoVisitante.Clear();
            txbEliminarPartidoId.Clear();
            txbActualizarPartidoId.Clear();
            txbMarcadorLocal.Clear();
            txbMarcadorVisitante.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDeportes();
            CargarPartidos();
            LimpiarCampos();
        }
    }
}
