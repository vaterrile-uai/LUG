namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDeporte = new Label();
            cmbDeporte = new ComboBox();
            lblEquipoLocal = new Label();
            txbEquipoLocal = new TextBox();
            lblEquipoVisitante = new Label();
            txbEquipoVisitante = new TextBox();
            lblFechaDelPartido = new Label();
            dtpFechaDelPartido = new DateTimePicker();
            dgvPartidos = new DataGridView();
            btnGuardar = new Button();
            lblEliminarPartido = new Label();
            lblEliminarPartidoId = new Label();
            txbEliminarPartidoId = new TextBox();
            btnEliminar = new Button();
            lblActualizarPartido = new Label();
            lblActualizarPartidoId = new Label();
            txbActualizarPartidoId = new TextBox();
            lblMarcadorLocal = new Label();
            txbMarcadorLocal = new TextBox();
            lblMarcadorVisitante = new Label();
            txbMarcadorVisitante = new TextBox();
            btnModificar = new Button();
            lblNuevoPartido = new Label();
            lblTodosLosPartidos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // lblDeporte
            // 
            lblDeporte.AutoSize = true;
            lblDeporte.Location = new Point(12, 72);
            lblDeporte.Name = "lblDeporte";
            lblDeporte.Size = new Size(49, 15);
            lblDeporte.TabIndex = 0;
            lblDeporte.Text = "Deporte";
            // 
            // cmbDeporte
            // 
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(12, 90);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(237, 23);
            cmbDeporte.TabIndex = 1;
            // 
            // lblEquipoLocal
            // 
            lblEquipoLocal.AutoSize = true;
            lblEquipoLocal.Location = new Point(12, 116);
            lblEquipoLocal.Name = "lblEquipoLocal";
            lblEquipoLocal.Size = new Size(75, 15);
            lblEquipoLocal.TabIndex = 2;
            lblEquipoLocal.Text = "Equipo Local";
            // 
            // txbEquipoLocal
            // 
            txbEquipoLocal.Location = new Point(12, 134);
            txbEquipoLocal.Name = "txbEquipoLocal";
            txbEquipoLocal.Size = new Size(237, 23);
            txbEquipoLocal.TabIndex = 3;
            // 
            // lblEquipoVisitante
            // 
            lblEquipoVisitante.AutoSize = true;
            lblEquipoVisitante.Location = new Point(12, 160);
            lblEquipoVisitante.Name = "lblEquipoVisitante";
            lblEquipoVisitante.Size = new Size(92, 15);
            lblEquipoVisitante.TabIndex = 4;
            lblEquipoVisitante.Text = "Equipo Visitante";
            // 
            // txbEquipoVisitante
            // 
            txbEquipoVisitante.Location = new Point(12, 178);
            txbEquipoVisitante.Name = "txbEquipoVisitante";
            txbEquipoVisitante.Size = new Size(237, 23);
            txbEquipoVisitante.TabIndex = 5;
            // 
            // lblFechaDelPartido
            // 
            lblFechaDelPartido.AutoSize = true;
            lblFechaDelPartido.Location = new Point(12, 204);
            lblFechaDelPartido.Name = "lblFechaDelPartido";
            lblFechaDelPartido.Size = new Size(98, 15);
            lblFechaDelPartido.TabIndex = 6;
            lblFechaDelPartido.Text = "Fecha del Partido";
            // 
            // dtpFechaDelPartido
            // 
            dtpFechaDelPartido.Location = new Point(12, 222);
            dtpFechaDelPartido.Name = "dtpFechaDelPartido";
            dtpFechaDelPartido.Size = new Size(237, 23);
            dtpFechaDelPartido.TabIndex = 7;
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(255, 90);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.Size = new Size(533, 184);
            dgvPartidos.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 251);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(237, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblEliminarPartido
            // 
            lblEliminarPartido.AutoSize = true;
            lblEliminarPartido.Location = new Point(255, 277);
            lblEliminarPartido.Name = "lblEliminarPartido";
            lblEliminarPartido.Size = new Size(91, 15);
            lblEliminarPartido.TabIndex = 10;
            lblEliminarPartido.Text = "Eliminar Partido";
            // 
            // lblEliminarPartidoId
            // 
            lblEliminarPartidoId.AutoSize = true;
            lblEliminarPartidoId.Location = new Point(255, 292);
            lblEliminarPartidoId.Name = "lblEliminarPartidoId";
            lblEliminarPartidoId.Size = new Size(71, 15);
            lblEliminarPartidoId.TabIndex = 11;
            lblEliminarPartidoId.Text = "Ingrese el ID";
            // 
            // txbEliminarPartidoId
            // 
            txbEliminarPartidoId.Location = new Point(255, 310);
            txbEliminarPartidoId.Name = "txbEliminarPartidoId";
            txbEliminarPartidoId.Size = new Size(237, 23);
            txbEliminarPartidoId.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 339);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(237, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblActualizarPartido
            // 
            lblActualizarPartido.AutoSize = true;
            lblActualizarPartido.Location = new Point(551, 277);
            lblActualizarPartido.Name = "lblActualizarPartido";
            lblActualizarPartido.Size = new Size(154, 15);
            lblActualizarPartido.TabIndex = 14;
            lblActualizarPartido.Text = "Actualizar Marcador Partido";
            // 
            // lblActualizarPartidoId
            // 
            lblActualizarPartidoId.AutoSize = true;
            lblActualizarPartidoId.Location = new Point(551, 292);
            lblActualizarPartidoId.Name = "lblActualizarPartidoId";
            lblActualizarPartidoId.Size = new Size(71, 15);
            lblActualizarPartidoId.TabIndex = 15;
            lblActualizarPartidoId.Text = "Ingrese el ID";
            // 
            // txbActualizarPartidoId
            // 
            txbActualizarPartidoId.Location = new Point(551, 310);
            txbActualizarPartidoId.Name = "txbActualizarPartidoId";
            txbActualizarPartidoId.Size = new Size(237, 23);
            txbActualizarPartidoId.TabIndex = 16;
            // 
            // lblMarcadorLocal
            // 
            lblMarcadorLocal.AutoSize = true;
            lblMarcadorLocal.Location = new Point(551, 336);
            lblMarcadorLocal.Name = "lblMarcadorLocal";
            lblMarcadorLocal.Size = new Size(89, 15);
            lblMarcadorLocal.TabIndex = 17;
            lblMarcadorLocal.Text = "Marcador Local";
            // 
            // txbMarcadorLocal
            // 
            txbMarcadorLocal.Location = new Point(551, 354);
            txbMarcadorLocal.Name = "txbMarcadorLocal";
            txbMarcadorLocal.Size = new Size(106, 23);
            txbMarcadorLocal.TabIndex = 18;
            // 
            // lblMarcadorVisitante
            // 
            lblMarcadorVisitante.AutoSize = true;
            lblMarcadorVisitante.Location = new Point(682, 336);
            lblMarcadorVisitante.Name = "lblMarcadorVisitante";
            lblMarcadorVisitante.Size = new Size(106, 15);
            lblMarcadorVisitante.TabIndex = 19;
            lblMarcadorVisitante.Text = "Marcador Visitante";
            // 
            // txbMarcadorVisitante
            // 
            txbMarcadorVisitante.Location = new Point(682, 354);
            txbMarcadorVisitante.Name = "txbMarcadorVisitante";
            txbMarcadorVisitante.Size = new Size(106, 23);
            txbMarcadorVisitante.TabIndex = 20;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(551, 383);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(237, 23);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblNuevoPartido
            // 
            lblNuevoPartido.AutoSize = true;
            lblNuevoPartido.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNuevoPartido.Location = new Point(12, 9);
            lblNuevoPartido.Name = "lblNuevoPartido";
            lblNuevoPartido.Size = new Size(209, 32);
            lblNuevoPartido.TabIndex = 22;
            lblNuevoPartido.Text = "NUEVO PARTIDO";
            // 
            // lblTodosLosPartidos
            // 
            lblTodosLosPartidos.AutoSize = true;
            lblTodosLosPartidos.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTodosLosPartidos.Location = new Point(255, 9);
            lblTodosLosPartidos.Name = "lblTodosLosPartidos";
            lblTodosLosPartidos.Size = new Size(268, 32);
            lblTodosLosPartidos.TabIndex = 23;
            lblTodosLosPartidos.Text = "TODOS LOS PARTIDOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTodosLosPartidos);
            Controls.Add(lblNuevoPartido);
            Controls.Add(btnModificar);
            Controls.Add(txbMarcadorVisitante);
            Controls.Add(lblMarcadorVisitante);
            Controls.Add(txbMarcadorLocal);
            Controls.Add(lblMarcadorLocal);
            Controls.Add(txbActualizarPartidoId);
            Controls.Add(lblActualizarPartidoId);
            Controls.Add(lblActualizarPartido);
            Controls.Add(btnEliminar);
            Controls.Add(txbEliminarPartidoId);
            Controls.Add(lblEliminarPartidoId);
            Controls.Add(lblEliminarPartido);
            Controls.Add(btnGuardar);
            Controls.Add(dgvPartidos);
            Controls.Add(dtpFechaDelPartido);
            Controls.Add(lblFechaDelPartido);
            Controls.Add(txbEquipoVisitante);
            Controls.Add(lblEquipoVisitante);
            Controls.Add(txbEquipoLocal);
            Controls.Add(lblEquipoLocal);
            Controls.Add(cmbDeporte);
            Controls.Add(lblDeporte);
            Name = "Form1";
            Text = "Primer Parcial";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeporte;
        private ComboBox cmbDeporte;
        private Label lblEquipoLocal;
        private TextBox txbEquipoLocal;
        private Label lblEquipoVisitante;
        private TextBox txbEquipoVisitante;
        private Label lblFechaDelPartido;
        private DateTimePicker dtpFechaDelPartido;
        private DataGridView dgvPartidos;
        private Button btnGuardar;
        private Label lblEliminarPartido;
        private Label lblEliminarPartidoId;
        private TextBox txbEliminarPartidoId;
        private Button btnEliminar;
        private Label lblActualizarPartido;
        private Label lblActualizarPartidoId;
        private TextBox txbActualizarPartidoId;
        private Label lblMarcadorLocal;
        private TextBox txbMarcadorLocal;
        private Label lblMarcadorVisitante;
        private TextBox txbMarcadorVisitante;
        private Button btnModificar;
        private Label lblNuevoPartido;
        private Label lblTodosLosPartidos;
    }
}
