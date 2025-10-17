namespace ABMInquilinos.app.Vistas
{
    partial class FrmDetalleInquilino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagen = new PictureBox();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lbContador = new Label();
            txtNombre = new TextBox();
            txtTipoDoc = new TextBox();
            chkDatosContrato = new CheckBox();
            label2 = new Label();
            txtApellido = new TextBox();
            txtDoc = new TextBox();
            txtDireccion = new TextBox();
            txtBarrio = new TextBox();
            txtCiudad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            chkAlquilando = new CheckBox();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lbMts2 = new Label();
            txtDuracion = new TextBox();
            txtFin = new TextBox();
            txtDireccionPropiedad = new TextBox();
            label16 = new Label();
            txtInicio = new TextBox();
            txtNroContrato = new TextBox();
            label11 = new Label();
            txtMonto = new TextBox();
            label18 = new Label();
            txtProvincia = new TextBox();
            pnlDetalleContrato = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            pnlDetalleContrato.SuspendLayout();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(264, 116);
            pbImagen.Margin = new Padding(3, 4, 3, 4);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(296, 384);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(514, 508);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(51, 52);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnterior.Location = new Point(264, 508);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(51, 52);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lbContador
            // 
            lbContador.AutoSize = true;
            lbContador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbContador.Location = new Point(400, 524);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(39, 25);
            lbContador.TabIndex = 3;
            lbContador.Text = "0/0";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 171);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Location = new Point(130, 255);
            txtTipoDoc.Margin = new Padding(3, 4, 3, 4);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.ReadOnly = true;
            txtTipoDoc.Size = new Size(114, 27);
            txtTipoDoc.TabIndex = 5;
            // 
            // chkDatosContrato
            // 
            chkDatosContrato.AutoSize = true;
            chkDatosContrato.Location = new Point(174, 587);
            chkDatosContrato.Margin = new Padding(3, 4, 3, 4);
            chkDatosContrato.Name = "chkDatosContrato";
            chkDatosContrato.Size = new Size(183, 24);
            chkDatosContrato.TabIndex = 6;
            chkDatosContrato.Text = "Mostrar datos contrato";
            chkDatosContrato.UseVisualStyleBackColor = true;
            chkDatosContrato.Click += chkDatosContrato_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 175);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(361, 171);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 9;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(361, 255);
            txtDoc.Margin = new Padding(3, 4, 3, 4);
            txtDoc.Name = "txtDoc";
            txtDoc.ReadOnly = true;
            txtDoc.Size = new Size(114, 27);
            txtDoc.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 348);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(114, 27);
            txtDireccion.TabIndex = 11;
            // 
            // txtBarrio
            // 
            txtBarrio.Location = new Point(361, 345);
            txtBarrio.Margin = new Padding(3, 4, 3, 4);
            txtBarrio.Name = "txtBarrio";
            txtBarrio.ReadOnly = true;
            txtBarrio.Size = new Size(114, 27);
            txtBarrio.TabIndex = 12;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(130, 428);
            txtCiudad.Margin = new Padding(3, 4, 3, 4);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.ReadOnly = true;
            txtCiudad.Size = new Size(114, 27);
            txtCiudad.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 175);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 259);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 16;
            label4.Text = "Tipo Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 261);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 17;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 345);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 18;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 352);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 19;
            label7.Text = "Barrio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 432);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 20;
            label8.Text = "Ciudad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(175, 49);
            label10.Name = "label10";
            label10.Size = new Size(224, 37);
            label10.TabIndex = 22;
            label10.Text = "Detalles Inquilino";
            // 
            // chkAlquilando
            // 
            chkAlquilando.AutoSize = true;
            chkAlquilando.Enabled = false;
            chkAlquilando.Location = new Point(174, 525);
            chkAlquilando.Margin = new Padding(3, 4, 3, 4);
            chkAlquilando.Name = "chkAlquilando";
            chkAlquilando.Size = new Size(104, 24);
            chkAlquilando.TabIndex = 23;
            chkAlquilando.Text = "Alquilando";
            chkAlquilando.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 355);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 37;
            label9.Text = "Duracion Contrato";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 297);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 35;
            label12.Text = "Fecha Fin";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(367, 81);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 34;
            label13.Text = "Direccion:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(55, 239);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 33;
            label14.Text = "Fecha Inicio";
            // 
            // lbMts2
            // 
            lbMts2.AutoSize = true;
            lbMts2.Location = new Point(264, 81);
            lbMts2.Name = "lbMts2";
            lbMts2.Size = new Size(44, 20);
            lbMts2.TabIndex = 32;
            lbMts2.Text = "Mts2:";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(142, 351);
            txtDuracion.Margin = new Padding(3, 4, 3, 4);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.ReadOnly = true;
            txtDuracion.Size = new Size(114, 27);
            txtDuracion.TabIndex = 31;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(142, 293);
            txtFin.Margin = new Padding(3, 4, 3, 4);
            txtFin.Name = "txtFin";
            txtFin.ReadOnly = true;
            txtFin.Size = new Size(114, 27);
            txtFin.TabIndex = 29;
            // 
            // txtDireccionPropiedad
            // 
            txtDireccionPropiedad.Location = new Point(442, 77);
            txtDireccionPropiedad.Margin = new Padding(3, 4, 3, 4);
            txtDireccionPropiedad.Name = "txtDireccionPropiedad";
            txtDireccionPropiedad.ReadOnly = true;
            txtDireccionPropiedad.Size = new Size(114, 27);
            txtDireccionPropiedad.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(46, 175);
            label16.Name = "label16";
            label16.Size = new Size(97, 20);
            label16.TabIndex = 26;
            label16.Text = "Nro contrato:";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(142, 235);
            txtInicio.Margin = new Padding(3, 4, 3, 4);
            txtInicio.Name = "txtInicio";
            txtInicio.ReadOnly = true;
            txtInicio.Size = new Size(114, 27);
            txtInicio.TabIndex = 25;
            // 
            // txtNroContrato
            // 
            txtNroContrato.Location = new Point(142, 171);
            txtNroContrato.Margin = new Padding(3, 4, 3, 4);
            txtNroContrato.Name = "txtNroContrato";
            txtNroContrato.ReadOnly = true;
            txtNroContrato.Size = new Size(114, 27);
            txtNroContrato.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 417);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 39;
            label11.Text = "Monto Alquiler";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(142, 413);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(114, 27);
            txtMonto.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(271, 428);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 43;
            label18.Text = "Provincia";
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(361, 421);
            txtProvincia.Margin = new Padding(3, 4, 3, 4);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.ReadOnly = true;
            txtProvincia.Size = new Size(114, 27);
            txtProvincia.TabIndex = 42;
            // 
            // pnlDetalleContrato
            // 
            pnlDetalleContrato.Controls.Add(label1);
            pnlDetalleContrato.Controls.Add(pbImagen);
            pnlDetalleContrato.Controls.Add(btnSiguiente);
            pnlDetalleContrato.Controls.Add(btnAnterior);
            pnlDetalleContrato.Controls.Add(label11);
            pnlDetalleContrato.Controls.Add(lbContador);
            pnlDetalleContrato.Controls.Add(txtMonto);
            pnlDetalleContrato.Controls.Add(txtNroContrato);
            pnlDetalleContrato.Controls.Add(label9);
            pnlDetalleContrato.Controls.Add(txtInicio);
            pnlDetalleContrato.Controls.Add(label12);
            pnlDetalleContrato.Controls.Add(label16);
            pnlDetalleContrato.Controls.Add(label13);
            pnlDetalleContrato.Controls.Add(txtDireccionPropiedad);
            pnlDetalleContrato.Controls.Add(label14);
            pnlDetalleContrato.Controls.Add(txtFin);
            pnlDetalleContrato.Controls.Add(lbMts2);
            pnlDetalleContrato.Controls.Add(txtDuracion);
            pnlDetalleContrato.Location = new Point(509, 32);
            pnlDetalleContrato.Margin = new Padding(3, 4, 3, 4);
            pnlDetalleContrato.Name = "pnlDetalleContrato";
            pnlDetalleContrato.Size = new Size(574, 580);
            pnlDetalleContrato.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 17);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 45;
            label1.Text = "Detalles Contrato";
            // 
            // FrmDetalleInquilino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 76, 95);
            ClientSize = new Size(1104, 655);
            Controls.Add(pnlDetalleContrato);
            Controls.Add(label18);
            Controls.Add(txtProvincia);
            Controls.Add(chkAlquilando);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCiudad);
            Controls.Add(txtBarrio);
            Controls.Add(txtDireccion);
            Controls.Add(txtDoc);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(chkDatosContrato);
            Controls.Add(txtTipoDoc);
            Controls.Add(txtNombre);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDetalleInquilino";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetalleInquilino";
            Load += FrmDetalleInquilino_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            pnlDetalleContrato.ResumeLayout(false);
            pnlDetalleContrato.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagen;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lbContador;
        private TextBox txtNombre;
        private TextBox txtTipoDoc;
        private CheckBox chkDatosContrato;
        private Label label2;
        private TextBox txtApellido;
        private TextBox txtDoc;
        private TextBox txtDireccion;
        private TextBox txtBarrio;
        private TextBox txtCiudad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private CheckBox chkAlquilando;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lbMts2;
        private TextBox txtDuracion;
        private TextBox txtFin;
        private TextBox txtDireccionPropiedad;
        private Label label16;
        private TextBox txtInicio;
        private TextBox txtNroContrato;
        private Label label11;
        private TextBox txtMonto;
        private Label label18;
        private TextBox txtProvincia;
        private Panel pnlDetalleContrato;
        private Label label1;
    }
}